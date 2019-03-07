namespace DominoTournament
{
    partial class Turnir
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
            this.numberOfTourLbl = new System.Windows.Forms.Label();
            this.panelOfAll = new System.Windows.Forms.FlowLayoutPanel();
            this.startTourBtn = new System.Windows.Forms.Button();
            this.nextTourBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfTourLbl
            // 
            this.numberOfTourLbl.AutoSize = true;
            this.numberOfTourLbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfTourLbl.Location = new System.Drawing.Point(12, 9);
            this.numberOfTourLbl.Name = "numberOfTourLbl";
            this.numberOfTourLbl.Size = new System.Drawing.Size(148, 65);
            this.numberOfTourLbl.TabIndex = 1;
            this.numberOfTourLbl.Text = "1 тур";
            // 
            // panelOfAll
            // 
            this.panelOfAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOfAll.AutoScroll = true;
            this.panelOfAll.Location = new System.Drawing.Point(23, 77);
            this.panelOfAll.Name = "panelOfAll";
            this.panelOfAll.Size = new System.Drawing.Size(1197, 602);
            this.panelOfAll.TabIndex = 2;
            // 
            // startTourBtn
            // 
            this.startTourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startTourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTourBtn.Location = new System.Drawing.Point(23, 701);
            this.startTourBtn.Name = "startTourBtn";
            this.startTourBtn.Size = new System.Drawing.Size(420, 40);
            this.startTourBtn.TabIndex = 3;
            this.startTourBtn.Text = "Запустить тур";
            this.startTourBtn.UseVisualStyleBackColor = true;
            this.startTourBtn.Click += new System.EventHandler(this.startTourBtn_Click);
            // 
            // nextTourBtn
            // 
            this.nextTourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextTourBtn.Enabled = false;
            this.nextTourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextTourBtn.Location = new System.Drawing.Point(800, 701);
            this.nextTourBtn.Name = "nextTourBtn";
            this.nextTourBtn.Size = new System.Drawing.Size(420, 40);
            this.nextTourBtn.TabIndex = 4;
            this.nextTourBtn.Text = "Следующий тур";
            this.nextTourBtn.UseVisualStyleBackColor = true;
            // 
            // Turnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.nextTourBtn);
            this.Controls.Add(this.startTourBtn);
            this.Controls.Add(this.panelOfAll);
            this.Controls.Add(this.numberOfTourLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Turnir";
            this.Text = "КИТ Домино Турнир";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numberOfTourLbl;
        private System.Windows.Forms.FlowLayoutPanel panelOfAll;
        private System.Windows.Forms.Button startTourBtn;
        private System.Windows.Forms.Button nextTourBtn;
    }
}