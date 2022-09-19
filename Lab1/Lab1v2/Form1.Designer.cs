namespace Lab1v2
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
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.trackBarCircle = new System.Windows.Forms.TrackBar();
            this.pictureBoxRectagle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSin = new System.Windows.Forms.PictureBox();
            this.trackBarRectangle = new System.Windows.Forms.TrackBar();
            this.trackBarSin = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectagle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.Location = new System.Drawing.Point(36, 37);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(207, 189);
            this.pictureBoxCircle.TabIndex = 0;
            this.pictureBoxCircle.TabStop = false;
            this.pictureBoxCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // trackBarCircle
            // 
            this.trackBarCircle.Location = new System.Drawing.Point(48, 284);
            this.trackBarCircle.Name = "trackBarCircle";
            this.trackBarCircle.Size = new System.Drawing.Size(175, 56);
            this.trackBarCircle.TabIndex = 1;
            this.trackBarCircle.Scroll += new System.EventHandler(this.trackBarCircle_Scroll);
            // 
            // pictureBoxRectagle
            // 
            this.pictureBoxRectagle.Location = new System.Drawing.Point(296, 37);
            this.pictureBoxRectagle.Name = "pictureBoxRectagle";
            this.pictureBoxRectagle.Size = new System.Drawing.Size(207, 189);
            this.pictureBoxRectagle.TabIndex = 2;
            this.pictureBoxRectagle.TabStop = false;
            this.pictureBoxRectagle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRectagle_Paint);
            // 
            // pictureBoxSin
            // 
            this.pictureBoxSin.Location = new System.Drawing.Point(568, 37);
            this.pictureBoxSin.Name = "pictureBoxSin";
            this.pictureBoxSin.Size = new System.Drawing.Size(207, 189);
            this.pictureBoxSin.TabIndex = 3;
            this.pictureBoxSin.TabStop = false;
            this.pictureBoxSin.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSin_Paint);
            // 
            // trackBarRectangle
            // 
            this.trackBarRectangle.Location = new System.Drawing.Point(310, 284);
            this.trackBarRectangle.Name = "trackBarRectangle";
            this.trackBarRectangle.Size = new System.Drawing.Size(175, 56);
            this.trackBarRectangle.TabIndex = 4;
            // 
            // trackBarSin
            // 
            this.trackBarSin.Location = new System.Drawing.Point(590, 284);
            this.trackBarSin.Name = "trackBarSin";
            this.trackBarSin.Size = new System.Drawing.Size(175, 56);
            this.trackBarSin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarSin);
            this.Controls.Add(this.trackBarRectangle);
            this.Controls.Add(this.pictureBoxSin);
            this.Controls.Add(this.pictureBoxRectagle);
            this.Controls.Add(this.trackBarCircle);
            this.Controls.Add(this.pictureBoxCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectagle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxCircle;
        private TrackBar trackBarCircle;
        private PictureBox pictureBoxRectagle;
        private PictureBox pictureBoxSin;
        private TrackBar trackBarRectangle;
        private TrackBar trackBarSin;
    }
}