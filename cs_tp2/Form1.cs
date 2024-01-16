namespace cs_tp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fichier ExtraitForm1.cs
        private void ExtraireMetaDonnees(PaintEventArgs e)
        {
            try
            {
                Image theImage = new Bitmap("Z:/perso/bts/cs/tp2/Image3_A380.jpg");

                Font font1 = new Font("Arial", 10);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                int X = 10;
                int Y = 10;

                String l_img = "largeur de l'image : " + theImage.Width.ToString() + " px";
                String h_img = "hauteur de l'image : " + theImage.Height.ToString() + " px";
                String res_h = "résolution horizontale : " + theImage.HorizontalResolution.ToString() + " ppp";
                String res_v = "résolution verticale : " + theImage.VerticalResolution.ToString() + " ppp";
                String prof_code = "profondeur de codage : " + ((int)theImage.PixelFormat).ToString() + " couleurs possibles";

                e.Graphics.DrawString(l_img, font1, blackBrush, X, Y);
                Y += font1.Height;
                e.Graphics.DrawString(h_img, font1, blackBrush, X, Y);
                Y += font1.Height;
                e.Graphics.DrawString(res_h, font1, blackBrush, X, Y);
                Y += font1.Height;
                e.Graphics.DrawString(res_v, font1, blackBrush, X, Y);
                Y += font1.Height;
                e.Graphics.DrawString(prof_code, font1, blackBrush, X, Y);
                Y += font1.Height;

                font1.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Il y a une erreur." +
                    "Vérifier le chemin d'acces du fichier...");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ExtraireMetaDonnees(e);
        }

    }
}