﻿namespace PuntoPrestamo
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
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.leftpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closebuttom = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttom)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 44);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(204, 496);
            this.leftpanel.TabIndex = 0;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.toppanel.Controls.Add(this.bunifuCustomLabel1);
            this.toppanel.Controls.Add(this.closebuttom);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(924, 44);
            this.toppanel.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 22);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Punto Prestamo";
            // 
            // closebuttom
            // 
            this.closebuttom.BackColor = System.Drawing.Color.Transparent;
            this.closebuttom.Image = ((System.Drawing.Image)(resources.GetObject("closebuttom.Image")));
            this.closebuttom.ImageActive = null;
            this.closebuttom.Location = new System.Drawing.Point(889, 12);
            this.closebuttom.Name = "closebuttom";
            this.closebuttom.Size = new System.Drawing.Size(23, 23);
            this.closebuttom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebuttom.TabIndex = 0;
            this.closebuttom.TabStop = false;
            this.closebuttom.Zoom = 10;
            this.closebuttom.Click += new System.EventHandler(this.closebuttom_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(212)))));
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(204, 44);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(720, 496);
            this.mainpanel.TabIndex = 2;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.Fixed = true;
            this.TopPanelDragControl.Horizontal = true;
            this.TopPanelDragControl.TargetControl = this.toppanel;
            this.TopPanelDragControl.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 540);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Punto Prestamo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel toppanel;
        private Bunifu.Framework.UI.BunifuImageButton closebuttom;
        private Bunifu.Framework.UI.BunifuDragControl TopPanelDragControl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

