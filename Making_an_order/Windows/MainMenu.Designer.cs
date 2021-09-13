
namespace Making_an_order
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.imgPizza = new System.Windows.Forms.PictureBox();
            this.btnMakingAnOrder = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.lFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(239, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAboutUs.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAboutUs.Location = new System.Drawing.Point(239, 211);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(113, 35);
            this.btnAboutUs.TabIndex = 3;
            this.btnAboutUs.Text = "О нас";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // imgPizza
            // 
            this.imgPizza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPizza.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgPizza.Image = ((System.Drawing.Image)(resources.GetObject("imgPizza.Image")));
            this.imgPizza.Location = new System.Drawing.Point(92, 12);
            this.imgPizza.Name = "imgPizza";
            this.imgPizza.Size = new System.Drawing.Size(240, 181);
            this.imgPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPizza.TabIndex = 4;
            this.imgPizza.TabStop = false;
            // 
            // btnMakingAnOrder
            // 
            this.btnMakingAnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMakingAnOrder.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMakingAnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakingAnOrder.Location = new System.Drawing.Point(72, 211);
            this.btnMakingAnOrder.Name = "btnMakingAnOrder";
            this.btnMakingAnOrder.Size = new System.Drawing.Size(113, 35);
            this.btnMakingAnOrder.TabIndex = 1;
            this.btnMakingAnOrder.Text = "Оформить заказ";
            this.btnMakingAnOrder.UseVisualStyleBackColor = false;
            this.btnMakingAnOrder.Click += new System.EventHandler(this.btnMakingAnOrder_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFeedback.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFeedback.Location = new System.Drawing.Point(72, 264);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(113, 35);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Оставить комментарий";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // lFeedback
            // 
            this.lFeedback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lFeedback.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFeedback.Location = new System.Drawing.Point(12, 317);
            this.lFeedback.Name = "lFeedback";
            this.lFeedback.Size = new System.Drawing.Size(407, 39);
            this.lFeedback.TabIndex = 7;
            this.lFeedback.Text = "*При оставлении комментария в качестве бонуса вам будет предоставлен промокод, вв" +
    "едя его вы сможете получить скидку";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(431, 354);
            this.Controls.Add(this.lFeedback);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnMakingAnOrder);
            this.Controls.Add(this.imgPizza);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пиццерия \"Папа Луи\"";
            ((System.ComponentModel.ISupportInitialize)(this.imgPizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.PictureBox imgPizza;
        private System.Windows.Forms.Button btnMakingAnOrder;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Label lFeedback;
    }
}

