namespace DominoContest
{
    partial class Form1
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
            this.chooseDir = new System.Windows.Forms.Button();
            this.pathToDir = new System.Windows.Forms.TextBox();
            this.scanDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseDir
            // 
            this.chooseDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDir.Location = new System.Drawing.Point(12, 12);
            this.chooseDir.Name = "chooseDir";
            this.chooseDir.Size = new System.Drawing.Size(466, 69);
            this.chooseDir.TabIndex = 1;
            this.chooseDir.Text = "Выберите папку с решениями участников";
            this.chooseDir.UseVisualStyleBackColor = true;
            this.chooseDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathToDir
            // 
            this.pathToDir.Location = new System.Drawing.Point(12, 12);
            this.pathToDir.Name = "pathToDir";
            this.pathToDir.Size = new System.Drawing.Size(466, 22);
            this.pathToDir.TabIndex = 2;
            this.pathToDir.Visible = false;
            // 
            // scanDir
            // 
            this.scanDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanDir.Location = new System.Drawing.Point(12, 40);
            this.scanDir.Name = "scanDir";
            this.scanDir.Size = new System.Drawing.Size(466, 41);
            this.scanDir.TabIndex = 3;
            this.scanDir.Text = "Сканировать папку";
            this.scanDir.UseVisualStyleBackColor = true;
            this.scanDir.Visible = false;
            this.scanDir.Click += new System.EventHandler(this.scanDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 93);
            this.Controls.Add(this.scanDir);
            this.Controls.Add(this.pathToDir);
            this.Controls.Add(this.chooseDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Domino Contest Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseDir;
        private System.Windows.Forms.TextBox pathToDir;
        private System.Windows.Forms.Button scanDir;
    }
}

