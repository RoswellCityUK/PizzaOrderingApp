namespace PizzaOrderingApp
{
    partial class EditToppings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditToppings));
            this.lstToppings = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddChicken = new System.Windows.Forms.Button();
            this.btnAddPepperoni = new System.Windows.Forms.Button();
            this.btnAddHam = new System.Windows.Forms.Button();
            this.btnAddBeef = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddFetaCheese = new System.Windows.Forms.Button();
            this.btnAddBlueCheese = new System.Windows.Forms.Button();
            this.btnAddCheddar = new System.Windows.Forms.Button();
            this.btnAddGoatCheese = new System.Windows.Forms.Button();
            this.btnAddOlives = new System.Windows.Forms.Button();
            this.btnAddCarrots = new System.Windows.Forms.Button();
            this.btnAddPineapple = new System.Windows.Forms.Button();
            this.btnAddPepper = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblToppingsTotalPrice = new System.Windows.Forms.Label();
            this.lblToppingsTotalAmount = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstToppings
            // 
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.ItemHeight = 15;
            this.lstToppings.Location = new System.Drawing.Point(12, 42);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.Size = new System.Drawing.Size(210, 229);
            this.lstToppings.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Edit Toppings";
            // 
            // btnAddChicken
            // 
            this.btnAddChicken.Location = new System.Drawing.Point(228, 42);
            this.btnAddChicken.Name = "btnAddChicken";
            this.btnAddChicken.Size = new System.Drawing.Size(97, 23);
            this.btnAddChicken.TabIndex = 2;
            this.btnAddChicken.Text = "Add Chicken";
            this.btnAddChicken.UseVisualStyleBackColor = true;
            this.btnAddChicken.Click += new System.EventHandler(this.btnAddChicken_Click);
            // 
            // btnAddPepperoni
            // 
            this.btnAddPepperoni.Location = new System.Drawing.Point(331, 42);
            this.btnAddPepperoni.Name = "btnAddPepperoni";
            this.btnAddPepperoni.Size = new System.Drawing.Size(97, 23);
            this.btnAddPepperoni.TabIndex = 3;
            this.btnAddPepperoni.Text = "Add Pepperoni";
            this.btnAddPepperoni.UseVisualStyleBackColor = true;
            this.btnAddPepperoni.Click += new System.EventHandler(this.btnAddPepperoni_Click);
            // 
            // btnAddHam
            // 
            this.btnAddHam.Location = new System.Drawing.Point(228, 71);
            this.btnAddHam.Name = "btnAddHam";
            this.btnAddHam.Size = new System.Drawing.Size(97, 23);
            this.btnAddHam.TabIndex = 4;
            this.btnAddHam.Text = "Add Ham";
            this.btnAddHam.UseVisualStyleBackColor = true;
            this.btnAddHam.Click += new System.EventHandler(this.btnAddHam_Click);
            // 
            // btnAddBeef
            // 
            this.btnAddBeef.Location = new System.Drawing.Point(331, 71);
            this.btnAddBeef.Name = "btnAddBeef";
            this.btnAddBeef.Size = new System.Drawing.Size(97, 23);
            this.btnAddBeef.TabIndex = 5;
            this.btnAddBeef.Text = "Add Beef";
            this.btnAddBeef.UseVisualStyleBackColor = true;
            this.btnAddBeef.Click += new System.EventHandler(this.btnAddBeef_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(115, 307);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveSelected.TabIndex = 8;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddFetaCheese);
            this.groupBox1.Controls.Add(this.btnAddBlueCheese);
            this.groupBox1.Controls.Add(this.btnAddCheddar);
            this.groupBox1.Controls.Add(this.btnAddGoatCheese);
            this.groupBox1.Location = new System.Drawing.Point(228, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cheese";
            // 
            // btnAddFetaCheese
            // 
            this.btnAddFetaCheese.Location = new System.Drawing.Point(104, 51);
            this.btnAddFetaCheese.Name = "btnAddFetaCheese";
            this.btnAddFetaCheese.Size = new System.Drawing.Size(91, 23);
            this.btnAddFetaCheese.TabIndex = 14;
            this.btnAddFetaCheese.Text = "Feta Cheese";
            this.btnAddFetaCheese.UseVisualStyleBackColor = true;
            this.btnAddFetaCheese.Click += new System.EventHandler(this.btnAddFetaCheese_Click);
            // 
            // btnAddBlueCheese
            // 
            this.btnAddBlueCheese.Location = new System.Drawing.Point(6, 51);
            this.btnAddBlueCheese.Name = "btnAddBlueCheese";
            this.btnAddBlueCheese.Size = new System.Drawing.Size(91, 23);
            this.btnAddBlueCheese.TabIndex = 13;
            this.btnAddBlueCheese.Text = "Blue Cheese";
            this.btnAddBlueCheese.UseVisualStyleBackColor = true;
            this.btnAddBlueCheese.Click += new System.EventHandler(this.btnAddBlueCheese_Click);
            // 
            // btnAddCheddar
            // 
            this.btnAddCheddar.Location = new System.Drawing.Point(103, 22);
            this.btnAddCheddar.Name = "btnAddCheddar";
            this.btnAddCheddar.Size = new System.Drawing.Size(92, 23);
            this.btnAddCheddar.TabIndex = 12;
            this.btnAddCheddar.Text = "Cheddar";
            this.btnAddCheddar.UseVisualStyleBackColor = true;
            this.btnAddCheddar.Click += new System.EventHandler(this.btnAddCheddar_Click);
            // 
            // btnAddGoatCheese
            // 
            this.btnAddGoatCheese.Location = new System.Drawing.Point(6, 22);
            this.btnAddGoatCheese.Name = "btnAddGoatCheese";
            this.btnAddGoatCheese.Size = new System.Drawing.Size(91, 23);
            this.btnAddGoatCheese.TabIndex = 11;
            this.btnAddGoatCheese.Text = "Goat Cheese";
            this.btnAddGoatCheese.UseVisualStyleBackColor = true;
            this.btnAddGoatCheese.Click += new System.EventHandler(this.btnAddGoatCheese_Click);
            // 
            // btnAddOlives
            // 
            this.btnAddOlives.Location = new System.Drawing.Point(228, 212);
            this.btnAddOlives.Name = "btnAddOlives";
            this.btnAddOlives.Size = new System.Drawing.Size(97, 23);
            this.btnAddOlives.TabIndex = 11;
            this.btnAddOlives.Text = "Add Olives";
            this.btnAddOlives.UseVisualStyleBackColor = true;
            this.btnAddOlives.Click += new System.EventHandler(this.btnAddOlives_Click);
            // 
            // btnAddCarrots
            // 
            this.btnAddCarrots.Location = new System.Drawing.Point(331, 212);
            this.btnAddCarrots.Name = "btnAddCarrots";
            this.btnAddCarrots.Size = new System.Drawing.Size(97, 23);
            this.btnAddCarrots.TabIndex = 12;
            this.btnAddCarrots.Text = "Add Carrots";
            this.btnAddCarrots.UseVisualStyleBackColor = true;
            this.btnAddCarrots.Click += new System.EventHandler(this.btnAddCarrots_Click);
            // 
            // btnAddPineapple
            // 
            this.btnAddPineapple.Location = new System.Drawing.Point(228, 241);
            this.btnAddPineapple.Name = "btnAddPineapple";
            this.btnAddPineapple.Size = new System.Drawing.Size(97, 23);
            this.btnAddPineapple.TabIndex = 13;
            this.btnAddPineapple.Text = "Add Pineapple";
            this.btnAddPineapple.UseVisualStyleBackColor = true;
            this.btnAddPineapple.Click += new System.EventHandler(this.btnAddPineapple_Click);
            // 
            // btnAddPepper
            // 
            this.btnAddPepper.Location = new System.Drawing.Point(332, 241);
            this.btnAddPepper.Name = "btnAddPepper";
            this.btnAddPepper.Size = new System.Drawing.Size(97, 23);
            this.btnAddPepper.TabIndex = 14;
            this.btnAddPepper.Text = "Add Pepper";
            this.btnAddPepper.UseVisualStyleBackColor = true;
            this.btnAddPepper.Click += new System.EventHandler(this.btnAddPepper_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblToppingsTotalPrice
            // 
            this.lblToppingsTotalPrice.AutoSize = true;
            this.lblToppingsTotalPrice.Location = new System.Drawing.Point(12, 283);
            this.lblToppingsTotalPrice.Name = "lblToppingsTotalPrice";
            this.lblToppingsTotalPrice.Size = new System.Drawing.Size(64, 15);
            this.lblToppingsTotalPrice.TabIndex = 17;
            this.lblToppingsTotalPrice.Text = "Total price:";
            // 
            // lblToppingsTotalAmount
            // 
            this.lblToppingsTotalAmount.AutoSize = true;
            this.lblToppingsTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppingsTotalAmount.Location = new System.Drawing.Point(82, 278);
            this.lblToppingsTotalAmount.Name = "lblToppingsTotalAmount";
            this.lblToppingsTotalAmount.Size = new System.Drawing.Size(59, 21);
            this.lblToppingsTotalAmount.TabIndex = 18;
            this.lblToppingsTotalAmount.Text = "£34.99";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(12, 307);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(97, 23);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // EditToppings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(435, 340);
            this.Controls.Add(this.lblToppingsTotalAmount);
            this.Controls.Add(this.lblToppingsTotalPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPepper);
            this.Controls.Add(this.btnAddPineapple);
            this.Controls.Add(this.btnAddCarrots);
            this.Controls.Add(this.btnAddOlives);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddBeef);
            this.Controls.Add(this.btnAddHam);
            this.Controls.Add(this.btnAddPepperoni);
            this.Controls.Add(this.btnAddChicken);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstToppings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditToppings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Toppings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.toppingEditForm_Closing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstToppings;
        private Label lblTitle;
        private Button btnAddChicken;
        private Button btnAddPepperoni;
        private Button btnAddHam;
        private Button btnAddBeef;
        private Button btnRemoveSelected;
        private GroupBox groupBox1;
        private Button btnAddFetaCheese;
        private Button btnAddBlueCheese;
        private Button btnAddCheddar;
        private Button btnAddGoatCheese;
        private Button btnAddOlives;
        private Button btnAddCarrots;
        private Button btnAddPineapple;
        private Button btnAddPepper;
        private Button btnSave;
        private Button btnCancel;
        private Label lblToppingsTotalPrice;
        private Label lblToppingsTotalAmount;
        private Button btnClearAll;
    }
}