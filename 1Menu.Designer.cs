
namespace Otpusk
{
    partial class _1Menu
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
            this.labelLogo1 = new System.Windows.Forms.Label();
            this.buttonExit1 = new System.Windows.Forms.Button();
            this.buttonJoin1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogo1
            // 
            this.labelLogo1.AutoSize = true;
            this.labelLogo1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelLogo1.Location = new System.Drawing.Point(75, 50);
            this.labelLogo1.Name = "labelLogo1";
            this.labelLogo1.Size = new System.Drawing.Size(725, 55);
            this.labelLogo1.TabIndex = 0;
            this.labelLogo1.Text = "БРОНИРОВАНИЕ ОТПУСКОВ";
            // 
            // buttonExit1
            // 
            this.buttonExit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit1.Location = new System.Drawing.Point(350, 300);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(200, 50);
            this.buttonExit1.TabIndex = 1;
            this.buttonExit1.Text = "Выход";
            this.buttonExit1.UseVisualStyleBackColor = false;
            this.buttonExit1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonJoin1
            // 
            this.buttonJoin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonJoin1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJoin1.Location = new System.Drawing.Point(350, 200);
            this.buttonJoin1.Name = "buttonJoin1";
            this.buttonJoin1.Size = new System.Drawing.Size(200, 50);
            this.buttonJoin1.TabIndex = 2;
            this.buttonJoin1.Text = "Вход";
            this.buttonJoin1.UseVisualStyleBackColor = false;
            this.buttonJoin1.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // _1Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.buttonJoin1);
            this.Controls.Add(this.buttonExit1);
            this.Controls.Add(this.labelLogo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "_1Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo1;
        private System.Windows.Forms.Button buttonExit1;
        private System.Windows.Forms.Button buttonJoin1;
    }
}

