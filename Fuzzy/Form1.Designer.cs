namespace Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Difference = new System.Windows.Forms.TextBox();
            this.txt_DewPoint = new System.Windows.Forms.TextBox();
            this.txt_Electricity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Bulaniklastirma = new System.Windows.Forms.Button();
            this.btn_FuzzyRules = new System.Windows.Forms.Button();
            this.btn_Durulastirma = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Temperature(18~30)";
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_User.Location = new System.Drawing.Point(338, 51);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(205, 25);
            this.txt_User.TabIndex = 0;
            // 
            // txt_Difference
            // 
            this.txt_Difference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Difference.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Difference.Location = new System.Drawing.Point(338, 103);
            this.txt_Difference.Multiline = true;
            this.txt_Difference.Name = "txt_Difference";
            this.txt_Difference.Size = new System.Drawing.Size(206, 25);
            this.txt_Difference.TabIndex = 1;
            // 
            // txt_DewPoint
            // 
            this.txt_DewPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DewPoint.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DewPoint.Location = new System.Drawing.Point(338, 151);
            this.txt_DewPoint.Multiline = true;
            this.txt_DewPoint.Name = "txt_DewPoint";
            this.txt_DewPoint.Size = new System.Drawing.Size(206, 25);
            this.txt_DewPoint.TabIndex = 2;
            // 
            // txt_Electricity
            // 
            this.txt_Electricity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Electricity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Electricity.Location = new System.Drawing.Point(338, 200);
            this.txt_Electricity.Multiline = true;
            this.txt_Electricity.Name = "txt_Electricity";
            this.txt_Electricity.Size = new System.Drawing.Size(206, 25);
            this.txt_Electricity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature Difference(-1~3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dew Point Temperature(10~18)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(130)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Electricity Volt(130~220)";
            // 
            // btn_Bulaniklastirma
            // 
            this.btn_Bulaniklastirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.btn_Bulaniklastirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Bulaniklastirma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bulaniklastirma.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Bulaniklastirma.Location = new System.Drawing.Point(36, 270);
            this.btn_Bulaniklastirma.Name = "btn_Bulaniklastirma";
            this.btn_Bulaniklastirma.Size = new System.Drawing.Size(145, 45);
            this.btn_Bulaniklastirma.TabIndex = 8;
            this.btn_Bulaniklastirma.Text = "Bulanıklaştırma";
            this.btn_Bulaniklastirma.UseVisualStyleBackColor = false;
            this.btn_Bulaniklastirma.Click += new System.EventHandler(this.btn_Bulaniklastirma_Click);
            // 
            // btn_FuzzyRules
            // 
            this.btn_FuzzyRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.btn_FuzzyRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FuzzyRules.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FuzzyRules.ForeColor = System.Drawing.Color.Transparent;
            this.btn_FuzzyRules.Location = new System.Drawing.Point(218, 270);
            this.btn_FuzzyRules.Name = "btn_FuzzyRules";
            this.btn_FuzzyRules.Size = new System.Drawing.Size(145, 45);
            this.btn_FuzzyRules.TabIndex = 9;
            this.btn_FuzzyRules.Text = "Bulanık Kurallar";
            this.btn_FuzzyRules.UseVisualStyleBackColor = false;
            this.btn_FuzzyRules.Click += new System.EventHandler(this.btn_FuzzyRules_Click);
            // 
            // btn_Durulastirma
            // 
            this.btn_Durulastirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(61)))));
            this.btn_Durulastirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Durulastirma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Durulastirma.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Durulastirma.Location = new System.Drawing.Point(398, 270);
            this.btn_Durulastirma.Name = "btn_Durulastirma";
            this.btn_Durulastirma.Size = new System.Drawing.Size(145, 45);
            this.btn_Durulastirma.TabIndex = 10;
            this.btn_Durulastirma.Text = "Durulaştırma";
            this.btn_Durulastirma.UseVisualStyleBackColor = false;
            this.btn_Durulastirma.Click += new System.EventHandler(this.btn_Durulastirma_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.btn_kapat.ImageKey = "close.png";
            this.btn_kapat.ImageList = this.ımageList1;
            this.btn_kapat.Location = new System.Drawing.Point(534, 8);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(25, 25);
            this.btn_kapat.TabIndex = 11;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "close.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(576, 342);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_Durulastirma);
            this.Controls.Add(this.btn_FuzzyRules);
            this.Controls.Add(this.btn_Bulaniklastirma);
            this.Controls.Add(this.txt_Difference);
            this.Controls.Add(this.txt_DewPoint);
            this.Controls.Add(this.txt_Electricity);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Difference;
        private System.Windows.Forms.TextBox txt_DewPoint;
        private System.Windows.Forms.TextBox txt_Electricity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Bulaniklastirma;
        private System.Windows.Forms.Button btn_FuzzyRules;
        private System.Windows.Forms.Button btn_Durulastirma;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

