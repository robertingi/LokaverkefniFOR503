namespace Client
{
    partial class MathClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathClient));
            this.btnByrja = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtSvar = new System.Windows.Forms.TextBox();
            this.btnSenda = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnByrja
            // 
            this.btnByrja.Enabled = false;
            this.btnByrja.Location = new System.Drawing.Point(12, 200);
            this.btnByrja.Name = "btnByrja";
            this.btnByrja.Size = new System.Drawing.Size(173, 23);
            this.btnByrja.TabIndex = 0;
            this.btnByrja.Text = "Byrja";
            this.btnByrja.UseVisualStyleBackColor = true;
            this.btnByrja.Click += new System.EventHandler(this.btnByrja_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(9, 9);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(0, 13);
            this.lblConnection.TabIndex = 1;
            // 
            // txtMath
            // 
            this.txtMath.BackColor = System.Drawing.Color.White;
            this.txtMath.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMath.Location = new System.Drawing.Point(210, 65);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.ReadOnly = true;
            this.txtMath.Size = new System.Drawing.Size(266, 129);
            this.txtMath.TabIndex = 2;
            // 
            // txtSvar
            // 
            this.txtSvar.Location = new System.Drawing.Point(210, 203);
            this.txtSvar.Name = "txtSvar";
            this.txtSvar.Size = new System.Drawing.Size(205, 20);
            this.txtSvar.TabIndex = 3;
            // 
            // btnSenda
            // 
            this.btnSenda.Enabled = false;
            this.btnSenda.Location = new System.Drawing.Point(421, 200);
            this.btnSenda.Name = "btnSenda";
            this.btnSenda.Size = new System.Drawing.Size(56, 23);
            this.btnSenda.TabIndex = 0;
            this.btnSenda.Text = "Svara";
            this.btnSenda.UseVisualStyleBackColor = true;
            this.btnSenda.Click += new System.EventHandler(this.btnSenda_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(6, 30);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(61, 30);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(116, 30);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(49, 23);
            this.btnMulti.TabIndex = 4;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(210, 41);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(28, 13);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Stig:";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(14, 28);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(31, 17);
            this.rad1.TabIndex = 7;
            this.rad1.TabStop = true;
            this.rad1.Text = "1";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(69, 28);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(31, 17);
            this.rad2.TabIndex = 7;
            this.rad2.TabStop = true;
            this.rad2.Text = "2";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(124, 28);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(31, 17);
            this.rad3.TabIndex = 7;
            this.rad3.TabStop = true;
            this.rad3.Text = "3";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erfiðarstig";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.btnMulti);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veldu dæmi";
            // 
            // MathClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(504, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtSvar);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.btnSenda);
            this.Controls.Add(this.btnByrja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MathClient";
            this.Text = "Math Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnByrja;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtSvar;
        private System.Windows.Forms.Button btnSenda;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

