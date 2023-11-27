namespace Gomokucs
{
    partial class Gomoku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CvH = new System.Windows.Forms.RadioButton();
            this.HvH = new System.Windows.Forms.RadioButton();
            this.playerno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getc = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.gridsize = new System.Windows.Forms.Label();
            this.twoeonetimestwoeone = new System.Windows.Forms.RadioButton();
            this.teveltimestevel = new System.Windows.Forms.RadioButton();
            this.fifteentimesfifteen = new System.Windows.Forms.RadioButton();
            this.fivetimesfive = new System.Windows.Forms.RadioButton();
            this.threetimesthree = new System.Windows.Forms.RadioButton();
            this.panelforthegame = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getc);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.gridsize);
            this.panel1.Controls.Add(this.twoeonetimestwoeone);
            this.panel1.Controls.Add(this.teveltimestevel);
            this.panel1.Controls.Add(this.fifteentimesfifteen);
            this.panel1.Controls.Add(this.fivetimesfive);
            this.panel1.Controls.Add(this.threetimesthree);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CvH);
            this.panel2.Controls.Add(this.HvH);
            this.panel2.Controls.Add(this.playerno);
            this.panel2.Location = new System.Drawing.Point(198, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 50);
            this.panel2.TabIndex = 1;
            // 
            // CvH
            // 
            this.CvH.AutoSize = true;
            this.CvH.ForeColor = System.Drawing.Color.White;
            this.CvH.Location = new System.Drawing.Point(14, 26);
            this.CvH.Name = "CvH";
            this.CvH.Size = new System.Drawing.Size(121, 17);
            this.CvH.TabIndex = 12;
            this.CvH.TabStop = true;
            this.CvH.Text = "Computer vs Human";
            this.CvH.UseVisualStyleBackColor = true;
            this.CvH.CheckedChanged += new System.EventHandler(this.CvH_CheckedChanged);
            // 
            // HvH
            // 
            this.HvH.AutoSize = true;
            this.HvH.ForeColor = System.Drawing.Color.White;
            this.HvH.Location = new System.Drawing.Point(14, 6);
            this.HvH.Name = "HvH";
            this.HvH.Size = new System.Drawing.Size(110, 17);
            this.HvH.TabIndex = 0;
            this.HvH.TabStop = true;
            this.HvH.Text = "Human vs Human";
            this.HvH.UseVisualStyleBackColor = true;
            // 
            // playerno
            // 
            this.playerno.AutoSize = true;
            this.playerno.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerno.ForeColor = System.Drawing.Color.White;
            this.playerno.Location = new System.Drawing.Point(117, 26);
            this.playerno.Name = "playerno";
            this.playerno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerno.Size = new System.Drawing.Size(0, 21);
            this.playerno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Win Count";
            // 
            // getc
            // 
            this.getc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getc.Location = new System.Drawing.Point(30, 90);
            this.getc.Name = "getc";
            this.getc.Size = new System.Drawing.Size(156, 25);
            this.getc.TabIndex = 7;
            this.getc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getc.TextChanged += new System.EventHandler(this.getc_TextChanged);
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(456, 16);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(85, 99);
            this.start.TabIndex = 6;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // gridsize
            // 
            this.gridsize.AutoSize = true;
            this.gridsize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridsize.ForeColor = System.Drawing.Color.White;
            this.gridsize.Location = new System.Drawing.Point(3, 6);
            this.gridsize.Name = "gridsize";
            this.gridsize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridsize.Size = new System.Drawing.Size(85, 21);
            this.gridsize.TabIndex = 5;
            this.gridsize.Text = "Grid Size: ";
            // 
            // twoeonetimestwoeone
            // 
            this.twoeonetimestwoeone.AutoSize = true;
            this.twoeonetimestwoeone.ForeColor = System.Drawing.Color.White;
            this.twoeonetimestwoeone.Location = new System.Drawing.Point(394, 30);
            this.twoeonetimestwoeone.Name = "twoeonetimestwoeone";
            this.twoeonetimestwoeone.Size = new System.Drawing.Size(54, 17);
            this.twoeonetimestwoeone.TabIndex = 4;
            this.twoeonetimestwoeone.TabStop = true;
            this.twoeonetimestwoeone.Text = "20x20";
            this.twoeonetimestwoeone.UseVisualStyleBackColor = true;
            // 
            // teveltimestevel
            // 
            this.teveltimestevel.AutoSize = true;
            this.teveltimestevel.ForeColor = System.Drawing.Color.White;
            this.teveltimestevel.Location = new System.Drawing.Point(212, 30);
            this.teveltimestevel.Name = "teveltimestevel";
            this.teveltimestevel.Size = new System.Drawing.Size(54, 17);
            this.teveltimestevel.TabIndex = 3;
            this.teveltimestevel.TabStop = true;
            this.teveltimestevel.Text = "10x10";
            this.teveltimestevel.UseVisualStyleBackColor = true;
            // 
            // fifteentimesfifteen
            // 
            this.fifteentimesfifteen.AutoSize = true;
            this.fifteentimesfifteen.ForeColor = System.Drawing.Color.White;
            this.fifteentimesfifteen.Location = new System.Drawing.Point(303, 30);
            this.fifteentimesfifteen.Name = "fifteentimesfifteen";
            this.fifteentimesfifteen.Size = new System.Drawing.Size(54, 17);
            this.fifteentimesfifteen.TabIndex = 2;
            this.fifteentimesfifteen.TabStop = true;
            this.fifteentimesfifteen.Text = "15x15";
            this.fifteentimesfifteen.UseVisualStyleBackColor = true;
            // 
            // fivetimesfive
            // 
            this.fivetimesfive.AutoSize = true;
            this.fivetimesfive.ForeColor = System.Drawing.Color.White;
            this.fivetimesfive.Location = new System.Drawing.Point(121, 30);
            this.fivetimesfive.Name = "fivetimesfive";
            this.fivetimesfive.Size = new System.Drawing.Size(42, 17);
            this.fivetimesfive.TabIndex = 2;
            this.fivetimesfive.TabStop = true;
            this.fivetimesfive.Text = "5x5";
            this.fivetimesfive.UseVisualStyleBackColor = true;
            // 
            // threetimesthree
            // 
            this.threetimesthree.AutoSize = true;
            this.threetimesthree.ForeColor = System.Drawing.Color.White;
            this.threetimesthree.Location = new System.Drawing.Point(30, 30);
            this.threetimesthree.Name = "threetimesthree";
            this.threetimesthree.Size = new System.Drawing.Size(42, 17);
            this.threetimesthree.TabIndex = 1;
            this.threetimesthree.TabStop = true;
            this.threetimesthree.Text = "3x3";
            this.threetimesthree.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.threetimesthree.UseVisualStyleBackColor = true;
            // 
            // panelforthegame
            // 
            this.panelforthegame.Location = new System.Drawing.Point(1, 146);
            this.panelforthegame.Name = "panelforthegame";
            this.panelforthegame.Size = new System.Drawing.Size(574, 474);
            this.panelforthegame.TabIndex = 1;
            // 
            // Gomoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(576, 624);
            this.Controls.Add(this.panelforthegame);
            this.Controls.Add(this.panel1);
            this.Name = "Gomoku";
            this.Text = "Gomoku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton twoeonetimestwoeone;
        private System.Windows.Forms.RadioButton teveltimestevel;
        private System.Windows.Forms.RadioButton fifteentimesfifteen;
        private System.Windows.Forms.RadioButton fivetimesfive;
        private System.Windows.Forms.RadioButton threetimesthree;
        private System.Windows.Forms.TextBox getc;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label gridsize;
        private System.Windows.Forms.FlowLayoutPanel panelforthegame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton CvH;
        private System.Windows.Forms.RadioButton HvH;
    }
}

