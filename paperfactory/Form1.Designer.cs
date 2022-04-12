
namespace paperfactory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateBtn = new System.Windows.Forms.Button();
            this.folkCanvas = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationBtn = new System.Windows.Forms.Button();
            this.destinationTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveSuccessLbl = new System.Windows.Forms.Label();
            this.sourcesBtn = new System.Windows.Forms.Button();
            this.sourcesTxt = new System.Windows.Forms.TextBox();
            this.singleImgBox = new System.Windows.Forms.GroupBox();
            this.bulkGenerateBox = new System.Windows.Forms.GroupBox();
            this.autoSuccessLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autoGenBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.folkCanvas)).BeginInit();
            this.singleImgBox.SuspendLayout();
            this.bulkGenerateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(6, 24);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(192, 36);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // folkCanvas
            // 
            this.folkCanvas.Location = new System.Drawing.Point(12, 12);
            this.folkCanvas.Name = "folkCanvas";
            this.folkCanvas.Size = new System.Drawing.Size(400, 400);
            this.folkCanvas.TabIndex = 1;
            this.folkCanvas.TabStop = false;
            // 
            // destinationBtn
            // 
            this.destinationBtn.Location = new System.Drawing.Point(418, 49);
            this.destinationBtn.Name = "destinationBtn";
            this.destinationBtn.Size = new System.Drawing.Size(161, 23);
            this.destinationBtn.TabIndex = 2;
            this.destinationBtn.Text = "Select destination folder";
            this.destinationBtn.UseVisualStyleBackColor = true;
            this.destinationBtn.Click += new System.EventHandler(this.destinationBtn_Click);
            // 
            // destinationTxt
            // 
            this.destinationTxt.Location = new System.Drawing.Point(585, 49);
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.Size = new System.Drawing.Size(233, 23);
            this.destinationTxt.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(204, 24);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(192, 36);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveSuccessLbl
            // 
            this.saveSuccessLbl.AutoSize = true;
            this.saveSuccessLbl.ForeColor = System.Drawing.Color.Green;
            this.saveSuccessLbl.Location = new System.Drawing.Point(6, 74);
            this.saveSuccessLbl.Name = "saveSuccessLbl";
            this.saveSuccessLbl.Size = new System.Drawing.Size(64, 15);
            this.saveSuccessLbl.TabIndex = 5;
            this.saveSuccessLbl.Text = "save_result";
            // 
            // sourcesBtn
            // 
            this.sourcesBtn.Location = new System.Drawing.Point(418, 12);
            this.sourcesBtn.Name = "sourcesBtn";
            this.sourcesBtn.Size = new System.Drawing.Size(161, 23);
            this.sourcesBtn.TabIndex = 6;
            this.sourcesBtn.Text = "Select sources folder";
            this.sourcesBtn.UseVisualStyleBackColor = true;
            this.sourcesBtn.Click += new System.EventHandler(this.sourcesBtn_Click);
            // 
            // sourcesTxt
            // 
            this.sourcesTxt.Location = new System.Drawing.Point(585, 12);
            this.sourcesTxt.Name = "sourcesTxt";
            this.sourcesTxt.Size = new System.Drawing.Size(233, 23);
            this.sourcesTxt.TabIndex = 7;
            // 
            // singleImgBox
            // 
            this.singleImgBox.Controls.Add(this.generateBtn);
            this.singleImgBox.Controls.Add(this.saveBtn);
            this.singleImgBox.Controls.Add(this.saveSuccessLbl);
            this.singleImgBox.Location = new System.Drawing.Point(418, 90);
            this.singleImgBox.Name = "singleImgBox";
            this.singleImgBox.Size = new System.Drawing.Size(402, 104);
            this.singleImgBox.TabIndex = 8;
            this.singleImgBox.TabStop = false;
            this.singleImgBox.Text = "Single Image Preview";
            // 
            // bulkGenerateBox
            // 
            this.bulkGenerateBox.Controls.Add(this.cancelBtn);
            this.bulkGenerateBox.Controls.Add(this.progressBar1);
            this.bulkGenerateBox.Controls.Add(this.autoSuccessLbl);
            this.bulkGenerateBox.Controls.Add(this.label1);
            this.bulkGenerateBox.Controls.Add(this.autoGenBtn);
            this.bulkGenerateBox.Controls.Add(this.numericUpDown1);
            this.bulkGenerateBox.Location = new System.Drawing.Point(418, 206);
            this.bulkGenerateBox.Name = "bulkGenerateBox";
            this.bulkGenerateBox.Size = new System.Drawing.Size(402, 206);
            this.bulkGenerateBox.TabIndex = 9;
            this.bulkGenerateBox.TabStop = false;
            this.bulkGenerateBox.Text = "Bulk Generator";
            // 
            // autoSuccessLbl
            // 
            this.autoSuccessLbl.AutoSize = true;
            this.autoSuccessLbl.ForeColor = System.Drawing.Color.Green;
            this.autoSuccessLbl.Location = new System.Drawing.Point(5, 70);
            this.autoSuccessLbl.Name = "autoSuccessLbl";
            this.autoSuccessLbl.Size = new System.Drawing.Size(65, 15);
            this.autoSuccessLbl.TabIndex = 3;
            this.autoSuccessLbl.Text = "auto_result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Folks:";
            // 
            // autoGenBtn
            // 
            this.autoGenBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoGenBtn.Location = new System.Drawing.Point(5, 103);
            this.autoGenBtn.Name = "autoGenBtn";
            this.autoGenBtn.Size = new System.Drawing.Size(214, 60);
            this.autoGenBtn.TabIndex = 1;
            this.autoGenBtn.Text = "Auto Generate";
            this.autoGenBtn.UseVisualStyleBackColor = true;
            this.autoGenBtn.Click += new System.EventHandler(this.autoGenBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(110, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 170);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(225, 103);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(171, 60);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 422);
            this.Controls.Add(this.bulkGenerateBox);
            this.Controls.Add(this.singleImgBox);
            this.Controls.Add(this.sourcesTxt);
            this.Controls.Add(this.sourcesBtn);
            this.Controls.Add(this.destinationTxt);
            this.Controls.Add(this.destinationBtn);
            this.Controls.Add(this.folkCanvas);
            this.Name = "Form1";
            this.Text = "Paper Factory";
            ((System.ComponentModel.ISupportInitialize)(this.folkCanvas)).EndInit();
            this.singleImgBox.ResumeLayout(false);
            this.singleImgBox.PerformLayout();
            this.bulkGenerateBox.ResumeLayout(false);
            this.bulkGenerateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.PictureBox folkCanvas;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button destinationBtn;
        private System.Windows.Forms.TextBox destinationTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label saveSuccessLbl;
        private System.Windows.Forms.Button sourcesBtn;
        private System.Windows.Forms.TextBox sourcesTxt;
        private System.Windows.Forms.GroupBox singleImgBox;
        private System.Windows.Forms.GroupBox bulkGenerateBox;
        private System.Windows.Forms.Button autoGenBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label autoSuccessLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancelBtn;
    }
}

