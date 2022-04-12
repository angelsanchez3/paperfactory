using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paperfactory
{
    class AssetsRandomizer
    {
        private string sourcesFolderPath = ".";

        public AssetsRandomizer(string sourcesFolderPath)
        {
            if (!String.IsNullOrEmpty(sourcesFolderPath))
            {
                this.sourcesFolderPath = sourcesFolderPath;
            }
        }

        public Image background()
        {
            string assetPath = $"{sourcesFolderPath}\\background";
            int numberOfAssets = Directory.GetFiles(assetPath, "*", SearchOption.TopDirectoryOnly).Length;
            Random random = new Random();
            int number = random.Next(1, numberOfAssets);
            string background = $"{assetPath}\\background{number}.png";

            return Image.FromFile(background);
        }

        public Image[] hair()
        {
            // Base Hair e Top Hair é sempre a mesma combinação? Ou seja BH1 match com TH1, BH2 com TH2, etc?
            Random random = new Random();
            int number = random.Next(1, 4);
            string baseHair = $"{sourcesFolderPath}\\basehair\\basehair{number}.png";
            string topHair = $"{sourcesFolderPath}\\tophair\\tophair{number}.png";

            Image imgBaseHair = Image.FromFile(baseHair);
            Image imgTopHair = Image.FromFile(topHair);

            return new Image[] { imgBaseHair, imgTopHair };
        }

        public Image[] head()
        {
            // Numero de assets para a head é sempre igual?
            Random random = new Random();
            int number = random.Next(1, 4);

            string neck = $"{sourcesFolderPath}\\neck\\neck{number}.png";
            string ear = $"{sourcesFolderPath}\\ear\\ear{number}.png";
            string face = $"{sourcesFolderPath}\\face\\face{number}.png";
            string nose = $"{sourcesFolderPath}\\nose\\nose{number}.png";

            Image imgNeck = Image.FromFile(neck);
            Image imgFace = Image.FromFile(face);
            Image imgEar = Image.FromFile(ear);
            Image imgNose = Image.FromFile(nose);

            return new Image[] { imgNeck, imgEar, imgFace, imgNose };
        }

        public Image eyes()
        {
            Random random = new Random();
            int number = random.Next(1, 4);
            string eyes = $"{sourcesFolderPath}\\eye\\eye{number}.png";

            return Image.FromFile(eyes);
        }

        public Image lip()
        {
            Random random = new Random();
            int number = random.Next(1, 4);
            string lip = $"{sourcesFolderPath}\\lip\\lip{number}.png";

            return Image.FromFile(lip);
        }
    }
}
