namespace çiftboyutludizikullanıcıgiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.bilgitxt = new System.Windows.Forms.Label();
            this.kaydolbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı : ";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(477, 193);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(100, 27);
            this.adtxt.TabIndex = 1;
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(659, 184);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(109, 44);
            this.girisbtn.TabIndex = 2;
            this.girisbtn.Text = "Giriş yap";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "şifre :";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(477, 241);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 27);
            this.sifretxt.TabIndex = 1;
            // 
            // bilgitxt
            // 
            this.bilgitxt.AutoSize = true;
            this.bilgitxt.Location = new System.Drawing.Point(283, 447);
            this.bilgitxt.Name = "bilgitxt";
            this.bilgitxt.Size = new System.Drawing.Size(44, 22);
            this.bilgitxt.TabIndex = 0;
            this.bilgitxt.Text = "Bilgi";
            // 
            // kaydolbtn
            // 
            this.kaydolbtn.Location = new System.Drawing.Point(395, 340);
            this.kaydolbtn.Name = "kaydolbtn";
            this.kaydolbtn.Size = new System.Drawing.Size(109, 44);
            this.kaydolbtn.TabIndex = 2;
            this.kaydolbtn.Text = "Kaydol";
            this.kaydolbtn.UseVisualStyleBackColor = true;
            this.kaydolbtn.Visible = false;
            this.kaydolbtn.Click += new System.EventHandler(this.kaydolbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "id  : ";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(477, 147);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 27);
            this.idtxt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 537);
            this.Controls.Add(this.kaydolbtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.bilgitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label bilgitxt;
        private System.Windows.Forms.Button kaydolbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtxt;
    }
}

