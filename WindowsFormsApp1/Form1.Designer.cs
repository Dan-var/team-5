namespace WindowsFormsApp1
{
    partial class SignUpForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.passwordfield = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.namefield = new System.Windows.Forms.TextBox();
            this.surnamefield = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(130, 496);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(258, 62);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Зареєструватись";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 81);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реєстрація";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginfield
            // 
            this.loginfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfield.Location = new System.Drawing.Point(130, 221);
            this.loginfield.Multiline = true;
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(309, 48);
            this.loginfield.TabIndex = 3;
            this.loginfield.Enter += new System.EventHandler(this.loginfield_Enter);
            this.loginfield.Leave += new System.EventHandler(this.loginfield_Leave);
            // 
            // passwordfield
            // 
            this.passwordfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordfield.Location = new System.Drawing.Point(130, 308);
            this.passwordfield.Multiline = true;
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.Size = new System.Drawing.Size(309, 48);
            this.passwordfield.TabIndex = 4;
            this.passwordfield.UseSystemPasswordChar = true;
            this.passwordfield.Enter += new System.EventHandler(this.passwordfield_Enter);
            this.passwordfield.Leave += new System.EventHandler(this.passwordfield_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // namefield
            // 
            this.namefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namefield.Location = new System.Drawing.Point(130, 87);
            this.namefield.Multiline = true;
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(309, 48);
            this.namefield.TabIndex = 6;
            this.namefield.Text = "Введіть ім\'я";
            this.namefield.Enter += new System.EventHandler(this.namefield_Enter);
            this.namefield.Leave += new System.EventHandler(this.namefield_Leave);
            // 
            // surnamefield
            // 
            this.surnamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamefield.Location = new System.Drawing.Point(130, 158);
            this.surnamefield.Multiline = true;
            this.surnamefield.Name = "surnamefield";
            this.surnamefield.Size = new System.Drawing.Size(309, 48);
            this.surnamefield.TabIndex = 7;
            this.surnamefield.Enter += new System.EventHandler(this.surnamefield_Enter);
            this.surnamefield.Leave += new System.EventHandler(this.surnamefield_Leave);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 619);
            this.Controls.Add(this.surnamefield);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordfield);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignUpButton);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.TextBox passwordfield;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.TextBox surnamefield;
    }
}

