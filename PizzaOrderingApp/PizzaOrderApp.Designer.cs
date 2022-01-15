namespace PizzaOrderingApp
{
    partial class MainPizzaOrderApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPizzaOrderApp));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.gboxToppings = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.btnEditToppings = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.lblChooseToppings = new System.Windows.Forms.Label();
            this.cboChooseSauce = new System.Windows.Forms.ComboBox();
            this.lblChooseSauce = new System.Windows.Forms.Label();
            this.cboChooseDough = new System.Windows.Forms.ComboBox();
            this.lblChooseDough = new System.Windows.Forms.Label();
            this.cboChooseSize = new System.Windows.Forms.ComboBox();
            this.lblChooseSize = new System.Windows.Forms.Label();
            this.cboChoosePizza = new System.Windows.Forms.ComboBox();
            this.lblChoosePizzaDesc = new System.Windows.Forms.Label();
            this.lblChoosePizza = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.gboxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(108, 390);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(77, 25);
            this.lblTotalAmount.TabIndex = 33;
            this.lblTotalAmount.Text = "£ 34.99";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.Location = new System.Drawing.Point(12, 394);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(90, 20);
            this.lblOrderTotal.TabIndex = 32;
            this.lblOrderTotal.Text = "Order Total:";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboxToppings
            // 
            this.gboxToppings.Controls.Add(this.lblToppings);
            this.gboxToppings.Location = new System.Drawing.Point(12, 299);
            this.gboxToppings.Name = "gboxToppings";
            this.gboxToppings.Size = new System.Drawing.Size(354, 88);
            this.gboxToppings.TabIndex = 31;
            this.gboxToppings.TabStop = false;
            this.gboxToppings.Text = "Chosen toppings:";
            // 
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(6, 19);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(342, 66);
            this.lblToppings.TabIndex = 11;
            this.lblToppings.Text = "( xxx, xxx, xxx, xxx)";
            // 
            // btnEditToppings
            // 
            this.btnEditToppings.Location = new System.Drawing.Point(177, 270);
            this.btnEditToppings.Name = "btnEditToppings";
            this.btnEditToppings.Size = new System.Drawing.Size(189, 23);
            this.btnEditToppings.TabIndex = 30;
            this.btnEditToppings.Text = "Edit toppings";
            this.btnEditToppings.UseVisualStyleBackColor = true;
            this.btnEditToppings.Click += new System.EventHandler(this.BtnEditToppings_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(214, 394);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(152, 23);
            this.btnMakeOrder.TabIndex = 35;
            this.btnMakeOrder.Text = "Order and Pay";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.BtnMakeOrder_Click);
            // 
            // lblChooseToppings
            // 
            this.lblChooseToppings.AutoSize = true;
            this.lblChooseToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseToppings.Location = new System.Drawing.Point(12, 269);
            this.lblChooseToppings.Name = "lblChooseToppings";
            this.lblChooseToppings.Size = new System.Drawing.Size(140, 21);
            this.lblChooseToppings.TabIndex = 29;
            this.lblChooseToppings.Text = "Choose Toppings";
            // 
            // cboChooseSauce
            // 
            this.cboChooseSauce.FormattingEnabled = true;
            this.cboChooseSauce.Location = new System.Drawing.Point(177, 224);
            this.cboChooseSauce.Name = "cboChooseSauce";
            this.cboChooseSauce.Size = new System.Drawing.Size(189, 23);
            this.cboChooseSauce.TabIndex = 28;
            this.cboChooseSauce.SelectedIndexChanged += new System.EventHandler(this.CboChooseSauce_SelectedIndexChanged);
            // 
            // lblChooseSauce
            // 
            this.lblChooseSauce.AutoSize = true;
            this.lblChooseSauce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseSauce.Location = new System.Drawing.Point(12, 226);
            this.lblChooseSauce.Name = "lblChooseSauce";
            this.lblChooseSauce.Size = new System.Drawing.Size(115, 21);
            this.lblChooseSauce.TabIndex = 27;
            this.lblChooseSauce.Text = "Choose Sauce";
            // 
            // cboChooseDough
            // 
            this.cboChooseDough.FormattingEnabled = true;
            this.cboChooseDough.Location = new System.Drawing.Point(177, 185);
            this.cboChooseDough.Name = "cboChooseDough";
            this.cboChooseDough.Size = new System.Drawing.Size(189, 23);
            this.cboChooseDough.TabIndex = 26;
            this.cboChooseDough.SelectedIndexChanged += new System.EventHandler(this.CboChooseDough_SelectedIndexChanged);
            // 
            // lblChooseDough
            // 
            this.lblChooseDough.AutoSize = true;
            this.lblChooseDough.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseDough.Location = new System.Drawing.Point(12, 187);
            this.lblChooseDough.Name = "lblChooseDough";
            this.lblChooseDough.Size = new System.Drawing.Size(122, 21);
            this.lblChooseDough.TabIndex = 25;
            this.lblChooseDough.Text = "Choose Dough";
            // 
            // cboChooseSize
            // 
            this.cboChooseSize.FormattingEnabled = true;
            this.cboChooseSize.Location = new System.Drawing.Point(177, 144);
            this.cboChooseSize.Name = "cboChooseSize";
            this.cboChooseSize.Size = new System.Drawing.Size(189, 23);
            this.cboChooseSize.TabIndex = 24;
            this.cboChooseSize.SelectedIndexChanged += new System.EventHandler(this.CboChooseSize_SelectedIndexChanged);
            // 
            // lblChooseSize
            // 
            this.lblChooseSize.AutoSize = true;
            this.lblChooseSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseSize.Location = new System.Drawing.Point(12, 146);
            this.lblChooseSize.Name = "lblChooseSize";
            this.lblChooseSize.Size = new System.Drawing.Size(101, 21);
            this.lblChooseSize.TabIndex = 23;
            this.lblChooseSize.Text = "Choose Size";
            // 
            // cboChoosePizza
            // 
            this.cboChoosePizza.FormattingEnabled = true;
            this.cboChoosePizza.Location = new System.Drawing.Point(177, 71);
            this.cboChoosePizza.Name = "cboChoosePizza";
            this.cboChoosePizza.Size = new System.Drawing.Size(189, 23);
            this.cboChoosePizza.TabIndex = 22;
            this.cboChoosePizza.SelectedIndexChanged += new System.EventHandler(this.CboChoosePizza_SelectedIndexChanged);
            // 
            // lblChoosePizzaDesc
            // 
            this.lblChoosePizzaDesc.Location = new System.Drawing.Point(12, 94);
            this.lblChoosePizzaDesc.Name = "lblChoosePizzaDesc";
            this.lblChoosePizzaDesc.Size = new System.Drawing.Size(159, 35);
            this.lblChoosePizzaDesc.TabIndex = 21;
            this.lblChoosePizzaDesc.Text = "Choose our signature or make your custome pizza";
            // 
            // lblChoosePizza
            // 
            this.lblChoosePizza.AutoSize = true;
            this.lblChoosePizza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChoosePizza.Location = new System.Drawing.Point(12, 73);
            this.lblChoosePizza.Name = "lblChoosePizza";
            this.lblChoosePizza.Size = new System.Drawing.Size(110, 21);
            this.lblChoosePizza.TabIndex = 20;
            this.lblChoosePizza.Text = "Choose Pizza";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 30);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Johns\' Pizza order App";
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(12, 479);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(96, 23);
            this.btnOrderHistory.TabIndex = 37;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.BtnOrderHistory_Click);
            // 
            // MainPizzaOrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 511);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.gboxToppings);
            this.Controls.Add(this.btnEditToppings);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.lblChooseToppings);
            this.Controls.Add(this.cboChooseSauce);
            this.Controls.Add(this.lblChooseSauce);
            this.Controls.Add(this.cboChooseDough);
            this.Controls.Add(this.lblChooseDough);
            this.Controls.Add(this.cboChooseSize);
            this.Controls.Add(this.lblChooseSize);
            this.Controls.Add(this.cboChoosePizza);
            this.Controls.Add(this.lblChoosePizzaDesc);
            this.Controls.Add(this.lblChoosePizza);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPizzaOrderApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaOrderApp";
            this.gboxToppings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnExit;
        private Label lblTotalAmount;
        private Label lblOrderTotal;
        private GroupBox gboxToppings;
        private Label lblToppings;
        private Button btnEditToppings;
        private Button btnMakeOrder;
        private Label lblChooseToppings;
        private ComboBox cboChooseSauce;
        private Label lblChooseSauce;
        private ComboBox cboChooseDough;
        private Label lblChooseDough;
        private ComboBox cboChooseSize;
        private Label lblChooseSize;
        private ComboBox cboChoosePizza;
        private Label lblChoosePizzaDesc;
        private Label lblChoosePizza;
        private Label lblTitle;
        private Button btnOrderHistory;
    }
}