using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paperfactory
{
    public partial class Form1 : Form
    {
        private string sources_path;
        private string destination_path;
        private int folk_number;
        private Bitmap mergedImage;
        private decimal number_of_folks;

        public Form1()
        {
            InitializeComponent();
            sourcesBtn.Select();
            folkCanvas.Hide();
            saveBtn.Enabled = false;
            autoGenBtn.Enabled = false;
            saveSuccessLbl.Hide();
            autoSuccessLbl.Hide();
            number_of_folks = numericUpDown1.Value;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            bool generateResult = generate_folk();
            if (generateResult)
            {
                folkCanvas.Show();
                if (destination_path != null && sources_path != null)
                    saveBtn.Enabled = true;
            }
            else
            {
                saveSuccessLbl.Text = "An error occurred while generating";
                saveSuccessLbl.ForeColor = Color.Red;
            }
        }

        private void autoGenBtn_Click(object sender, EventArgs e)
        {
            lockAllButtons();

            number_of_folks = numericUpDown1.Value;
            this.progressBar1.Value = 0;
            this.progressBar1.Maximum = (int)number_of_folks;

            
            autoSuccessLbl.ForeColor = Color.Black;
            autoSuccessLbl.Text = $"Generating folks";
            autoSuccessLbl.Visible = true;

            bool genResult = true;
            bool saveResult = true;

            IList<string> csv_rows = new List<string>();

            for (int i = 0; i < number_of_folks && genResult && saveResult; i++)
            {
                string folkName = "folk_" + this.folk_number;
                genResult = generate_folk();
                saveResult = save_folk(folkName);
                csv_rows.Add(this.get_csv_row(this.folk_number, folkName));
                this.progressBar1.Value = i+1;
                folk_number++;
            }
            if (genResult && saveResult)
            {
                generate_csv(csv_rows);
                autoSuccessLbl.Text = $"{number_of_folks} folks generated successfully!";
                autoSuccessLbl.ForeColor = Color.Green;
            }
            else
            {
                autoSuccessLbl.Text = "An error occurred while generating";
                autoSuccessLbl.ForeColor = Color.Red;
            }

            unlockAllButtons();
        }

        private void lockAllButtons()
        {
            autoGenBtn.Enabled = false;
            generateBtn.Enabled = false;
            saveBtn.Enabled = false;
            destinationBtn.Enabled = false;
            sourcesBtn.Enabled = false;
        }

        private void unlockAllButtons()
        {
            autoGenBtn.Enabled = true;
            generateBtn.Enabled = true;
            saveBtn.Enabled = true;
            destinationBtn.Enabled = true;
            sourcesBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string folkName = "folk_" + this.folk_number;
            bool saveResult = save_folk(folkName);
            generate_csv(this.folk_number, folkName);
            if (saveResult)
            {
                saveSuccessLbl.Text = $"folk_{this.folk_number} was saved!";
                saveSuccessLbl.ForeColor = Color.Green;
                folk_number++;
                saveSuccessLbl.Show();
            }
            else
            {
                saveSuccessLbl.Text = "An error occurred while saving";
                saveSuccessLbl.ForeColor = Color.Red;
            }
        }

        private Bitmap mergeImages(List<Image> images)
        {
            int width = 1200;
            int height = 1200;
            Bitmap bitmap = new Bitmap(width, height);
            

                using (var graphics = Graphics.FromImage(bitmap))
                {
                    foreach (var image in images)
                    {
                        graphics.DrawImage(image, 0, 0);
                    }
                }

            return bitmap;
        }

        private void destinationBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                destination_path = folderBrowserDialog.SelectedPath;
                destinationTxt.Text = folderBrowserDialog.SelectedPath;

                if (folkCanvas.Visible)
                    saveBtn.Enabled = true;
                if (!String.IsNullOrEmpty(sourcesTxt.Text))
                    autoGenBtn.Enabled = true;
                IEnumerable<string> folks = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*", SearchOption.TopDirectoryOnly)
                                                   .Where(s => s.EndsWith("png"));
                this.folk_number = folks.Count() + 1;
            }
        }

        private void sourcesBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sources_path = folderBrowserDialog.SelectedPath;
                sourcesTxt.Text = folderBrowserDialog.SelectedPath;

                if (folkCanvas.Visible)
                    saveBtn.Enabled = true;
                if (!String.IsNullOrEmpty(destinationTxt.Text))
                    autoGenBtn.Enabled = true;
            }
        }

        

        private bool generate_folk()
        {
            try
            {
                AssetsRandomizer assetsRandomizer = new AssetsRandomizer(this.sources_path);
                Image background = assetsRandomizer.background();
                Image[] hair = assetsRandomizer.hair();
                Image[] head = assetsRandomizer.head();
                Image eyes = assetsRandomizer.eyes();
                Image lip = assetsRandomizer.lip();

                List<Image> images = new List<Image>
                {
                    background,
                    hair[0],
                    head[0], head[1], head[2], head[3],
                    eyes, lip,
                    hair[1]
                };

                mergedImage = mergeImages(images);
                folkCanvas.Image = new Bitmap(mergedImage, new Size(mergedImage.Width / 3, mergedImage.Height / 3));
                return true;
            }
            catch (Exception exception)
            {
                // loggar a excepção
                return false;
            }
        }

        private bool save_folk(string folkName)
        {
            string imagePath = $"{destination_path}\\{folkName}.png";

            try
            {
                Bitmap saveImg = new Bitmap(mergedImage);
                saveImg.Save(imagePath, ImageFormat.Png);
                return true;
            }
            catch (Exception exception)
            {
                // loggar a excepção
                return false;
            }
        }

        private void generate_csv(int number, string token_name)
        {
            //ticker_numbered|quantity_per_ticker|token_name|image_name|collection|rarity|outro
            //paperfolk0025|1|Paper Ricardo|paperfile4.png|1000+4 Collection|Distinct|outro whatever
            string row = $"paperfolk{number}|1|{token_name}|{token_name}.png|test collection|distinct|test outro";

            string csv_path = $"{this.destination_path}\\reportfile.csv";
            bool reportexists = File.Exists(csv_path);

            if (reportexists)
            {
                File.AppendAllText(csv_path, row);
            }
            else
            {
                File.WriteAllText(csv_path, row);
            }
        }

        private void generate_csv(IList<string> rows)
        {
            string csv_path = $"{this.destination_path}\\reportfile.csv";
            int length = rows.Count;
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                text.AppendLine(rows[i]);
            }
            File.AppendAllText(csv_path, text.ToString());

        }

        private string get_csv_row(int number, string token_name)
        {
            //ticker_numbered|quantity_per_ticker|token_name|image_name|collection|rarity|outro
            //paperfolk0025|1|Paper Ricardo|paperfile4.png|1000+4 Collection|Distinct|outro whatever
            return $"paperfolk{number}|1|{token_name}|{token_name}.png|test collection|distinct|test outro";
        }

        
    }
}
