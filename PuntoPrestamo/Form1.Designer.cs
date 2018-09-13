namespace PuntoPrestamo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(36, 81);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(250, 42);
            this.bunifuTextbox2.TabIndex = 0;
            this.bunifuTextbox2.text = "Bunifu TextBox";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bunifuTextbox2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
    }
}

