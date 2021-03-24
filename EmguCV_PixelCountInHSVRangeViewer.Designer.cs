namespace EmguCV_FunctionCustom
{
    partial class EmguCV_PixelCountInHSVRangeViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPixelCountScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbPixelCount = new System.Windows.Forms.PictureBox();
            this.pbQueryFrame = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueryFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPixelCountScore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 158);
            this.panel1.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1322, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.Location = new System.Drawing.Point(14, 131);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 17);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "ErrorMessage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(640, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "ROI #1";
            // 
            // lblPixelCountScore
            // 
            this.lblPixelCountScore.AutoSize = true;
            this.lblPixelCountScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblPixelCountScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPixelCountScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPixelCountScore.Location = new System.Drawing.Point(722, 12);
            this.lblPixelCountScore.Name = "lblPixelCountScore";
            this.lblPixelCountScore.Size = new System.Drawing.Size(175, 25);
            this.lblPixelCountScore.TabIndex = 31;
            this.lblPixelCountScore.Text = "Pixel Count Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Query Frame:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersion.Location = new System.Drawing.Point(1159, 9);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(217, 17);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "EmguCV_PixelCountInHSVRange";
            // 
            // pbPixelCount
            // 
            this.pbPixelCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbPixelCount.Location = new System.Drawing.Point(648, 42);
            this.pbPixelCount.Name = "pbPixelCount";
            this.pbPixelCount.Size = new System.Drawing.Size(777, 495);
            this.pbPixelCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPixelCount.TabIndex = 38;
            this.pbPixelCount.TabStop = false;
            // 
            // pbQueryFrame
            // 
            this.pbQueryFrame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbQueryFrame.Location = new System.Drawing.Point(12, 11);
            this.pbQueryFrame.Name = "pbQueryFrame";
            this.pbQueryFrame.Size = new System.Drawing.Size(610, 526);
            this.pbQueryFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueryFrame.TabIndex = 37;
            this.pbQueryFrame.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EmguCV_PixelCountInHSVRangeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1438, 705);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbPixelCount);
            this.Controls.Add(this.pbQueryFrame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmguCV_PixelCountInHSVRangeViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmguCV_PixelCountInHSVRangeViewer";
            this.Load += new System.EventHandler(this.EmguCV_PixelCountInHSVRangeViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPixelCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueryFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPixelCountScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pbPixelCount;
        private System.Windows.Forms.PictureBox pbQueryFrame;
        private System.Windows.Forms.Timer timer;
    }
}