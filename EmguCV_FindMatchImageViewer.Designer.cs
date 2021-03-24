namespace EmguCV_FunctionCustom
{
    partial class EmguCV_FindMatchImageViewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.rBoxCode = new System.Windows.Forms.RichTextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFindMatchScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.lblCorpWidth = new System.Windows.Forms.Label();
            this.lblCorpHeigth = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbROI = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TIMETOFAIL = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbROI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.rBoxCode);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblFindMatchScore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblConfidence);
            this.panel1.Controls.Add(this.lblCorpWidth);
            this.panel1.Controls.Add(this.lblCorpHeigth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 158);
            this.panel1.TabIndex = 26;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(435, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "JabilTest ROI";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeight.Location = new System.Drawing.Point(26, 85);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(74, 25);
            this.lblHeight.TabIndex = 33;
            this.lblHeight.Text = "Heigth:";
            // 
            // rBoxCode
            // 
            this.rBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.rBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBoxCode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rBoxCode.Location = new System.Drawing.Point(440, 45);
            this.rBoxCode.Name = "rBoxCode";
            this.rBoxCode.Size = new System.Drawing.Size(168, 103);
            this.rBoxCode.TabIndex = 45;
            this.rBoxCode.Text = "";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWidth.Location = new System.Drawing.Point(26, 49);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 25);
            this.lblWidth.TabIndex = 32;
            this.lblWidth.Text = "Width: ";
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
            // lblFindMatchScore
            // 
            this.lblFindMatchScore.AutoSize = true;
            this.lblFindMatchScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblFindMatchScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindMatchScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFindMatchScore.Location = new System.Drawing.Point(722, 12);
            this.lblFindMatchScore.Name = "lblFindMatchScore";
            this.lblFindMatchScore.Size = new System.Drawing.Size(172, 25);
            this.lblFindMatchScore.TabIndex = 31;
            this.lblFindMatchScore.Text = "Find Match Score:";
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
            // lblConfidence
            // 
            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfidence.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfidence.Location = new System.Drawing.Point(640, 114);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(118, 25);
            this.lblConfidence.TabIndex = 40;
            this.lblConfidence.Text = "Confidence:";
            // 
            // lblCorpWidth
            // 
            this.lblCorpWidth.AutoSize = true;
            this.lblCorpWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorpWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorpWidth.Location = new System.Drawing.Point(640, 48);
            this.lblCorpWidth.Name = "lblCorpWidth";
            this.lblCorpWidth.Size = new System.Drawing.Size(74, 25);
            this.lblCorpWidth.TabIndex = 34;
            this.lblCorpWidth.Text = "Width: ";
            // 
            // lblCorpHeigth
            // 
            this.lblCorpHeigth.AutoSize = true;
            this.lblCorpHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorpHeigth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorpHeigth.Location = new System.Drawing.Point(640, 82);
            this.lblCorpHeigth.Name = "lblCorpHeigth";
            this.lblCorpHeigth.Size = new System.Drawing.Size(74, 25);
            this.lblCorpHeigth.TabIndex = 35;
            this.lblCorpHeigth.Text = "Heigth:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersion.Location = new System.Drawing.Point(1156, 9);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(165, 17);
            this.lblVersion.TabIndex = 36;
            this.lblVersion.Text = "EmguCV_FindMatchImge";
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbOriginal.Location = new System.Drawing.Point(9, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(610, 526);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginal.TabIndex = 27;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOriginal_Paint);
            this.pbOriginal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOriginal_MouseDown);
            this.pbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOriginal_MouseMove);
            this.pbOriginal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOriginal_MouseUp);
            // 
            // pbROI
            // 
            this.pbROI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbROI.Location = new System.Drawing.Point(645, 43);
            this.pbROI.Name = "pbROI";
            this.pbROI.Size = new System.Drawing.Size(777, 495);
            this.pbROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbROI.TabIndex = 29;
            this.pbROI.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TIMETOFAIL
            // 
            this.TIMETOFAIL.Interval = 1000;
            this.TIMETOFAIL.Tick += new System.EventHandler(this.TIMETOFAIL_Tick);
            // 
            // EmguCV_FindMatchImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1438, 705);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbROI);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmguCV_FindMatchImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmguCV_FindMatchImageViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmguCV_FindMatchImageViewer_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbROI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbROI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblFindMatchScore;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblCorpHeigth;
        private System.Windows.Forms.Label lblCorpWidth;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblConfidence;
        private System.Windows.Forms.RichTextBox rBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TIMETOFAIL;
    }
}