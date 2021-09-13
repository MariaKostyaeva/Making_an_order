
namespace Making_an_order
{
    partial class FormTypeOfDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypeOfDelivery));
            this.grpTypeOfDelivery = new System.Windows.Forms.GroupBox();
            this.rbCourier = new System.Windows.Forms.RadioButton();
            this.rbPickUpService = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFurther = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpTypeOfDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTypeOfDelivery
            // 
            this.grpTypeOfDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTypeOfDelivery.Controls.Add(this.rbCourier);
            this.grpTypeOfDelivery.Controls.Add(this.rbPickUpService);
            this.grpTypeOfDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpTypeOfDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpTypeOfDelivery.Location = new System.Drawing.Point(100, 46);
            this.grpTypeOfDelivery.Name = "grpTypeOfDelivery";
            this.grpTypeOfDelivery.Size = new System.Drawing.Size(232, 165);
            this.grpTypeOfDelivery.TabIndex = 0;
            this.grpTypeOfDelivery.TabStop = false;
            this.grpTypeOfDelivery.Text = "Выберите вид доставки:";
            // 
            // rbCourier
            // 
            this.rbCourier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCourier.AutoSize = true;
            this.rbCourier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbCourier.Location = new System.Drawing.Point(52, 95);
            this.rbCourier.Name = "rbCourier";
            this.rbCourier.Size = new System.Drawing.Size(79, 24);
            this.rbCourier.TabIndex = 1;
            this.rbCourier.Text = "Курьер";
            this.rbCourier.UseVisualStyleBackColor = true;
            // 
            // rbPickUpService
            // 
            this.rbPickUpService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPickUpService.AutoSize = true;
            this.rbPickUpService.Checked = true;
            this.rbPickUpService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPickUpService.Location = new System.Drawing.Point(52, 45);
            this.rbPickUpService.Name = "rbPickUpService";
            this.rbPickUpService.Size = new System.Drawing.Size(112, 24);
            this.rbPickUpService.TabIndex = 0;
            this.rbPickUpService.TabStop = true;
            this.rbPickUpService.Text = "Самовывоз";
            this.rbPickUpService.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(100, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFurther
            // 
            this.btnFurther.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFurther.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFurther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFurther.Location = new System.Drawing.Point(219, 253);
            this.btnFurther.Name = "btnFurther";
            this.btnFurther.Size = new System.Drawing.Size(113, 35);
            this.btnFurther.TabIndex = 2;
            this.btnFurther.Text = "Далее";
            this.btnFurther.UseVisualStyleBackColor = false;
            this.btnFurther.Click += new System.EventHandler(this.btnFurther_Click);
            // 
            // FormTypeOfDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(431, 354);
            this.Controls.Add(this.btnFurther);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpTypeOfDelivery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTypeOfDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вид доставки";
            this.grpTypeOfDelivery.ResumeLayout(false);
            this.grpTypeOfDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTypeOfDelivery;
        private System.Windows.Forms.RadioButton rbCourier;
        private System.Windows.Forms.RadioButton rbPickUpService;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFurther;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}