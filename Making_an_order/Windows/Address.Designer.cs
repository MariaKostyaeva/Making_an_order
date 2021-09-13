
namespace Making_an_order
{
    partial class FormAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddress));
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.btnAdBack = new System.Windows.Forms.Button();
            this.btnAdFurther = new System.Windows.Forms.Button();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.lCity = new System.Windows.Forms.Label();
            this.lExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddress.Location = new System.Drawing.Point(65, 184);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(281, 24);
            this.tbAddress.TabIndex = 5;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddress.Location = new System.Drawing.Point(62, 139);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(286, 18);
            this.lAddress.TabIndex = 3;
            this.lAddress.Text = "Укажите улицу и номер дома/квартиры:";
            // 
            // btnAdBack
            // 
            this.btnAdBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdBack.Location = new System.Drawing.Point(65, 237);
            this.btnAdBack.Name = "btnAdBack";
            this.btnAdBack.Size = new System.Drawing.Size(113, 35);
            this.btnAdBack.TabIndex = 6;
            this.btnAdBack.Text = "Назад";
            this.btnAdBack.UseVisualStyleBackColor = false;
            this.btnAdBack.Click += new System.EventHandler(this.btnAdBack_Click);
            // 
            // btnAdFurther
            // 
            this.btnAdFurther.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdFurther.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdFurther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdFurther.Location = new System.Drawing.Point(235, 237);
            this.btnAdFurther.Name = "btnAdFurther";
            this.btnAdFurther.Size = new System.Drawing.Size(113, 35);
            this.btnAdFurther.TabIndex = 7;
            this.btnAdFurther.Text = "Далее";
            this.btnAdFurther.UseVisualStyleBackColor = false;
            this.btnAdFurther.Click += new System.EventHandler(this.btnAdFurther_Click);
            // 
            // cbAddress
            // 
            this.cbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Items.AddRange(new object[] {
            "Краснодар",
            "Москва",
            "Сочи",
            "Санкт-Петербург",
            "Пенза",
            "Астрахань"});
            this.cbAddress.Location = new System.Drawing.Point(65, 86);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(282, 26);
            this.cbAddress.TabIndex = 2;
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCity.Location = new System.Drawing.Point(63, 65);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(126, 18);
            this.lCity.TabIndex = 1;
            this.lCity.Text = "Выберите город:";
            // 
            // lExample
            // 
            this.lExample.AutoSize = true;
            this.lExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExample.Location = new System.Drawing.Point(63, 169);
            this.lExample.Name = "lExample";
            this.lExample.Size = new System.Drawing.Size(144, 12);
            this.lExample.TabIndex = 4;
            this.lExample.Text = "Пример:  ул.Победы, д.20, кв.29";
            // 
            // FormAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(431, 354);
            this.Controls.Add(this.lExample);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.btnAdFurther);
            this.Controls.Add(this.btnAdBack);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.tbAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адрес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Button btnAdBack;
        private System.Windows.Forms.Button btnAdFurther;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lExample;
    }
}