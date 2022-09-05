namespace MyNamespace
{
    using System;
    using System.Windows.Forms;

    public class MyForm : Form
    {
        private Button btnLoad;
        private PictureBox pboxPhoto;

        public MyForm()
        {
            this.Text = "Hello Form 1.2";

            // Create and configure the Button
            btnLoad = new Button();
            btnLoad.Text = "&Load";
            btnLoad.Left = 10;
            btnLoad.Top = 10;

            // Create and configure the PicutureBox
            pboxPhoto = new PictureBox();
            pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pboxPhoto.Width = this.Width / 2;
            pboxPhoto.Height = this.Height / 2;
            pboxPhoto.Left = (this.Width - pboxPhoto.Width) / 2;
            pboxPhoto.Top = (this.Height - pboxPhoto.Height) / 2;

            // Add our new controls to the Form
            this.Controls.Add(btnLoad);
            this.Controls.Add(pboxPhoto);
        }

        public static void Main(){
            Application.Run(new MyForm());
        }
    }
    
}