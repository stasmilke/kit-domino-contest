namespace DominoContest
{
    partial class RegistrationForm
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
            this.listOfSources = new System.Windows.Forms.ListBox();
            this.createDatabase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clrDB = new System.Windows.Forms.Button();
            this.clrON = new System.Windows.Forms.CheckBox();
            this.setParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfSources
            // 
            this.listOfSources.FormattingEnabled = true;
            this.listOfSources.ItemHeight = 16;
            this.listOfSources.Location = new System.Drawing.Point(12, 12);
            this.listOfSources.Name = "listOfSources";
            this.listOfSources.Size = new System.Drawing.Size(316, 308);
            this.listOfSources.TabIndex = 0;
            // 
            // createDatabase
            // 
            this.createDatabase.Location = new System.Drawing.Point(136, 365);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(192, 29);
            this.createDatabase.TabIndex = 1;
            this.createDatabase.Text = "Создать базу участников";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя базы:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 326);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 22);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "participants";
            // 
            // clrDB
            // 
            this.clrDB.Location = new System.Drawing.Point(36, 365);
            this.clrDB.Name = "clrDB";
            this.clrDB.Size = new System.Drawing.Size(90, 29);
            this.clrDB.TabIndex = 4;
            this.clrDB.Text = "Стереть БД";
            this.clrDB.UseVisualStyleBackColor = true;
            this.clrDB.Visible = false;
            this.clrDB.Click += new System.EventHandler(this.clrDB_Click);
            // 
            // clrON
            // 
            this.clrON.AutoSize = true;
            this.clrON.Location = new System.Drawing.Point(8, 370);
            this.clrON.Name = "clrON";
            this.clrON.Size = new System.Drawing.Size(118, 21);
            this.clrON.TabIndex = 5;
            this.clrON.Text = "Стереть базу";
            this.clrON.UseVisualStyleBackColor = true;
            this.clrON.CheckedChanged += new System.EventHandler(this.clrON_CheckedChanged);
            // 
            // setParams
            // 
            this.setParams.Location = new System.Drawing.Point(8, 401);
            this.setParams.Name = "setParams";
            this.setParams.Size = new System.Drawing.Size(320, 30);
            this.setParams.TabIndex = 6;
            this.setParams.Text = "Настройки подключения";
            this.setParams.UseVisualStyleBackColor = true;
            this.setParams.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(340, 443);
            this.Controls.Add(this.setParams);
            this.Controls.Add(this.clrON);
            this.Controls.Add(this.clrDB);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.listOfSources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация участников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfSources;
        private System.Windows.Forms.Button createDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button clrDB;
        private System.Windows.Forms.CheckBox clrON;
        private System.Windows.Forms.Button setParams;
    }
}