namespace lab4
{
    partial class Mainform
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.plain_text = new System.Windows.Forms.TextBox();
            this.get_p = new System.Windows.Forms.TextBox();
            this.get_q = new System.Windows.Forms.TextBox();
            this.show_module = new System.Windows.Forms.Label();
            this.encrypted_text = new System.Windows.Forms.TextBox();
            this.decrypted_text = new System.Windows.Forms.TextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.show_open_exp = new System.Windows.Forms.Label();
            this.show_secret_exp = new System.Windows.Forms.Label();
            this.set_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plain_text
            // 
            this.plain_text.Location = new System.Drawing.Point(12, 34);
            this.plain_text.Multiline = true;
            this.plain_text.Name = "plain_text";
            this.plain_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plain_text.Size = new System.Drawing.Size(574, 144);
            this.plain_text.TabIndex = 4;
            // 
            // get_p
            // 
            this.get_p.Location = new System.Drawing.Point(625, 34);
            this.get_p.Name = "get_p";
            this.get_p.Size = new System.Drawing.Size(100, 20);
            this.get_p.TabIndex = 4;
            // 
            // get_q
            // 
            this.get_q.Location = new System.Drawing.Point(625, 76);
            this.get_q.Name = "get_q";
            this.get_q.Size = new System.Drawing.Size(100, 20);
            this.get_q.TabIndex = 4;
            // 
            // show_module
            // 
            this.show_module.AutoSize = true;
            this.show_module.BackColor = System.Drawing.Color.Transparent;
            this.show_module.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_module.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show_module.Location = new System.Drawing.Point(689, 119);
            this.show_module.Name = "show_module";
            this.show_module.Size = new System.Drawing.Size(0, 15);
            this.show_module.TabIndex = 3;
            // 
            // encrypted_text
            // 
            this.encrypted_text.Location = new System.Drawing.Point(12, 217);
            this.encrypted_text.Multiline = true;
            this.encrypted_text.Name = "encrypted_text";
            this.encrypted_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encrypted_text.Size = new System.Drawing.Size(574, 145);
            this.encrypted_text.TabIndex = 4;
            // 
            // decrypted_text
            // 
            this.decrypted_text.Location = new System.Drawing.Point(12, 404);
            this.decrypted_text.Multiline = true;
            this.decrypted_text.Name = "decrypted_text";
            this.decrypted_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decrypted_text.Size = new System.Drawing.Size(574, 145);
            this.decrypted_text.TabIndex = 4;
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(608, 376);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(157, 77);
            this.encrypt_button.TabIndex = 6;
            this.encrypt_button.Text = "Шифровать";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(608, 472);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(157, 77);
            this.decrypt_button.TabIndex = 7;
            this.decrypt_button.Text = "Дешифровать";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Зашифрованный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дешифрованный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(605, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(605, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(605, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Модуль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(428, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Открытый ключ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(428, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Закрытый ключ:";
            // 
            // show_open_exp
            // 
            this.show_open_exp.AutoSize = true;
            this.show_open_exp.BackColor = System.Drawing.Color.Transparent;
            this.show_open_exp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_open_exp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show_open_exp.Location = new System.Drawing.Point(544, 190);
            this.show_open_exp.Name = "show_open_exp";
            this.show_open_exp.Size = new System.Drawing.Size(0, 15);
            this.show_open_exp.TabIndex = 16;
            // 
            // show_secret_exp
            // 
            this.show_secret_exp.AutoSize = true;
            this.show_secret_exp.BackColor = System.Drawing.Color.Transparent;
            this.show_secret_exp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_secret_exp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show_secret_exp.Location = new System.Drawing.Point(544, 376);
            this.show_secret_exp.Name = "show_secret_exp";
            this.show_secret_exp.Size = new System.Drawing.Size(0, 15);
            this.show_secret_exp.TabIndex = 17;
            // 
            // set_data
            // 
            this.set_data.Location = new System.Drawing.Point(608, 276);
            this.set_data.Name = "set_data";
            this.set_data.Size = new System.Drawing.Size(157, 77);
            this.set_data.TabIndex = 18;
            this.set_data.Text = "Задать данные";
            this.set_data.UseVisualStyleBackColor = true;
            this.set_data.Click += new System.EventHandler(this.set_data_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab4.Properties.Resources.color_lines_abstract_wide_wallpaper_1920x1080_0063;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 564);
            this.Controls.Add(this.set_data);
            this.Controls.Add(this.show_secret_exp);
            this.Controls.Add(this.show_open_exp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.decrypted_text);
            this.Controls.Add(this.encrypted_text);
            this.Controls.Add(this.show_module);
            this.Controls.Add(this.get_q);
            this.Controls.Add(this.get_p);
            this.Controls.Add(this.plain_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mainform";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plain_text;
        private System.Windows.Forms.TextBox get_p;
        private System.Windows.Forms.TextBox get_q;
        private System.Windows.Forms.Label show_module;
        private System.Windows.Forms.TextBox encrypted_text;
        private System.Windows.Forms.TextBox decrypted_text;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label show_open_exp;
        private System.Windows.Forms.Label show_secret_exp;
        private System.Windows.Forms.Button set_data;
    }
}

