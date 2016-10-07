namespace WindowsTerraClient
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lstPlaces = new System.Windows.Forms.ListBox();
            this.cmdShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.Location = new System.Drawing.Point(12, 9);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(108, 12);
            this.lblChoose.TabIndex = 11;
            this.lblChoose.Text = "Choose a location:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(136, 5);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(120, 21);
            this.txtPlace.TabIndex = 10;
            this.txtPlace.Text = "Kingston";
            // 
            // lstPlaces
            // 
            this.lstPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlaces.IntegralHeight = false;
            this.lstPlaces.Location = new System.Drawing.Point(15, 82);
            this.lstPlaces.Name = "lstPlaces";
            this.lstPlaces.Size = new System.Drawing.Size(316, 160);
            this.lstPlaces.TabIndex = 9;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(136, 29);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(120, 28);
            this.cmdShow.TabIndex = 8;
            this.cmdShow.Text = "Show All Matches";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 254);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lstPlaces);
            this.Controls.Add(this.cmdShow);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "TerraService Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblChoose;
        internal System.Windows.Forms.TextBox txtPlace;
        internal System.Windows.Forms.ListBox lstPlaces;
        internal System.Windows.Forms.Button cmdShow;
    }
}

