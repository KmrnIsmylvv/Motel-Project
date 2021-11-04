
namespace Motel
{
    partial class frmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadio));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnKralpop = new System.Windows.Forms.Button();
            this.btnKralfm = new System.Windows.Forms.Button();
            this.btnPower100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(802, 198);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnKralpop
            // 
            this.btnKralpop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKralpop.BackgroundImage")));
            this.btnKralpop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKralpop.Location = new System.Drawing.Point(89, 250);
            this.btnKralpop.Margin = new System.Windows.Forms.Padding(2);
            this.btnKralpop.Name = "btnKralpop";
            this.btnKralpop.Size = new System.Drawing.Size(144, 80);
            this.btnKralpop.TabIndex = 2;
            this.btnKralpop.UseVisualStyleBackColor = true;
            this.btnKralpop.Click += new System.EventHandler(this.btnKralpop_Click);
            // 
            // btnKralfm
            // 
            this.btnKralfm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKralfm.BackgroundImage")));
            this.btnKralfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKralfm.Location = new System.Drawing.Point(336, 250);
            this.btnKralfm.Margin = new System.Windows.Forms.Padding(2);
            this.btnKralfm.Name = "btnKralfm";
            this.btnKralfm.Size = new System.Drawing.Size(144, 80);
            this.btnKralfm.TabIndex = 3;
            this.btnKralfm.UseVisualStyleBackColor = true;
            this.btnKralfm.Click += new System.EventHandler(this.btnKralfm_Click);
            // 
            // btnPower100
            // 
            this.btnPower100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPower100.BackgroundImage")));
            this.btnPower100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower100.Location = new System.Drawing.Point(563, 250);
            this.btnPower100.Margin = new System.Windows.Forms.Padding(2);
            this.btnPower100.Name = "btnPower100";
            this.btnPower100.Size = new System.Drawing.Size(144, 80);
            this.btnPower100.TabIndex = 4;
            this.btnPower100.UseVisualStyleBackColor = true;
            this.btnPower100.Click += new System.EventHandler(this.btnPower100_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.btnPower100);
            this.Controls.Add(this.btnKralfm);
            this.Controls.Add(this.btnKralpop);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRadio";
            this.ShowIcon = false;
            this.Text = "Radio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnKralpop;
        private System.Windows.Forms.Button btnKralfm;
        private System.Windows.Forms.Button btnPower100;
    }
}