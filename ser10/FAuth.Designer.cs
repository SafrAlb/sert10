namespace ser10
{
    partial class FAuth
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
            this.btEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.btReg = new System.Windows.Forms.Button();
            this.cbShowPas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(145, 137);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(123, 33);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.Location = new System.Drawing.Point(109, 31);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(194, 26);
            this.tbLog.TabIndex = 3;
            // 
            // tbPas
            // 
            this.tbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPas.Location = new System.Drawing.Point(109, 88);
            this.tbPas.Name = "tbPas";
            this.tbPas.PasswordChar = '*';
            this.tbPas.Size = new System.Drawing.Size(194, 26);
            this.tbPas.TabIndex = 4;
            // 
            // btReg
            // 
            this.btReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReg.Location = new System.Drawing.Point(145, 188);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(123, 33);
            this.btReg.TabIndex = 5;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // cbShowPas
            // 
            this.cbShowPas.AutoSize = true;
            this.cbShowPas.Location = new System.Drawing.Point(25, 137);
            this.cbShowPas.Name = "cbShowPas";
            this.cbShowPas.Size = new System.Drawing.Size(114, 17);
            this.cbShowPas.TabIndex = 6;
            this.cbShowPas.Text = "Показать пароль";
            this.cbShowPas.UseVisualStyleBackColor = true;
            this.cbShowPas.CheckedChanged += new System.EventHandler(this.cbShowPas_CheckedChanged);
            // 
            // FAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(326, 240);
            this.Controls.Add(this.cbShowPas);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEnter);
            this.Name = "FAuth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.CheckBox cbShowPas;
    }
}

