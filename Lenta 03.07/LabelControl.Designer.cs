﻿namespace Lenta_03._07
{
    partial class LabelControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.labelPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 43);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelPicture
            // 
            this.labelPicture.Location = new System.Drawing.Point(3, 3);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(64, 61);
            this.labelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.labelPicture.TabIndex = 1;
            this.labelPicture.TabStop = false;
            // 
            // LabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelName);
            this.Name = "LabelControl";
            this.Size = new System.Drawing.Size(70, 101);
            ((System.ComponentModel.ISupportInitialize)(this.labelPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox labelPicture;
        public Label labelName;
    }
}
