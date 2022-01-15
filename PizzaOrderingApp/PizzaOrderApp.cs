namespace PizzaOrderingApp
{
    public partial class MainPizzaOrderApp : Form
    {
        public static Pizza chosenPizza = new();
        public static bool isEverythingInitialised = false;
        public static List<Pizza> pizzaOffer = new List<Pizza>();
        public static bool toppingsEditFormOpen = false;
        public List<PizzaDough> pizzaDoughsOffers = new();
        public List<PizzaSauce> pizzaSaucesOffer = new();
        public List<PizzaSize> pizzaSizesOffer = new();
        public List<PizzaTopping> pizzaToppingsOffer = new();

        public MainPizzaOrderApp()
        {
            InitializeComponent();
            BuildOffer();

            PizzaDataBinding();
            chosenPizza = pizzaOffer[0];
            isEverythingInitialised = true;
            RefreshOrderFormSelections();
        }

        public void RefreshOrderFormSelections()
        {
            cboChooseSize.SelectedItem = (PizzaSize)chosenPizza.Size;
            cboChooseDough.SelectedItem = (PizzaDough)chosenPizza.Dough;
            cboChooseSauce.SelectedItem = (PizzaSauce)chosenPizza.Sauce;
            lblToppings.Text = GetToppingsString();
            lblTotalAmount.Text = GetChosenPizzaPrice().ToString("C");
        }

        private void AddDoughToOffer(string doughName, double doughPrice)
        {
            pizzaDoughsOffers.Add(new PizzaDough() { Name = doughName, Price = doughPrice });
        }

        private void AddPizzaToOffer(string pizzaName, string pizzaDough, string pizzaSauce, string pizzaSize, string[] pizzaToppings)
        {
            List<PizzaTopping> temporaryToppingsList = new();
            foreach (string topping in pizzaToppings)
            {
                var test = pizzaToppingsOffer.Find(match: x => x.Name == topping);
                if (test != null) { temporaryToppingsList.Add(test); }
            }

            pizzaOffer.Add(new Pizza
            {
                Name = pizzaName,
                Dough = pizzaDoughsOffers.Find(match: x => x.Name.Contains(pizzaDough)),
                Sauce = pizzaSaucesOffer.Find(match: x => x.Name.Contains(pizzaSauce)),
                Size = pizzaSizesOffer.Find(match: x => x.Name.Contains(pizzaSize)),
                Toppings = temporaryToppingsList
            });
        }

        private void AddSizeToOffer(string sizeName, double sizePrice)
        {
            pizzaSizesOffer.Add(new PizzaSize() { Name = sizeName, Price = sizePrice });
        }

        private void AddSuaceToOffer(string sauceName, double saucePrice)
        {
            pizzaSaucesOffer.Add(new PizzaSauce() { Name = sauceName, Price = saucePrice });
        }

        private void AddToppingToOffer(string toppingName, double toppingPrice)
        {
            pizzaToppingsOffer.Add(new PizzaTopping() { Name = toppingName, Price = toppingPrice });
        }

        private void BtnClearForm_Click(object sender, EventArgs e)
        {
        }

        private void BtnEditToppings_Click(object sender, EventArgs e)
        {
            if (!toppingsEditFormOpen)
            {
                var editToppings = new EditToppings();
                editToppings.Owner = this;
                editToppings.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMakeOrder_Click(object sender, EventArgs e)
        {
        }

        private void BtnOrderHistory_Click(object sender, EventArgs e)
        {
        }

        private void BuildOffer()
        {
            AddToppingToOffer("Chicken", 1.99);
            AddToppingToOffer("Pepperoni", 1.89);
            AddToppingToOffer("Ham", 0.89);
            AddToppingToOffer("Beef", 0.89);
            AddToppingToOffer("Goat Cheese", 0.89);
            AddToppingToOffer("Cheddar", 0.89);
            AddToppingToOffer("Blue Cheese", 0.89);
            AddToppingToOffer("Feta Cheese", 0.89);
            AddToppingToOffer("Olives", 0.89);
            AddToppingToOffer("Carrots", 0.89);
            AddToppingToOffer("Pineapple", 0.89);
            AddToppingToOffer("Pepper", 0.89);

            AddDoughToOffer("Thick", 8.12);
            AddDoughToOffer("Thin", 10.12);

            AddSizeToOffer("Small", 1.50);
            AddSizeToOffer("Medium", 2.50);
            AddSizeToOffer("Large", 3.50);

            AddSuaceToOffer("Ketchup", 1.00);
            AddSuaceToOffer("Ultra Hot", 2.00);

            AddPizzaToOffer("Hawaiian Pizza", "Thick", "Ketchup", "Large", new string[] { "Ham", "Pineapple", "Pepper", "Feta Cheese" });
            AddPizzaToOffer("Mexican Pizza", "Thick", "Ultra Hot", "Large", new string[] { "Chicken", "Cheddar", "Carrots" });
            AddPizzaToOffer("Pepperoni Pizza", "Thick", "Ketchup", "Large", new string[] { "Pepperoni", "Cheddar", "Olives", "Pepper" });
        }

        private void CboChooseDough_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPizza.Dough = (PizzaDough)cboChooseDough.SelectedItem;
            RefreshOrderFormSelections();
        }

        private void CboChoosePizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPizza = (Pizza)cboChoosePizza.SelectedItem;
            RefreshOrderFormSelections();
        }

        private void CboChooseSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPizza.Sauce = (PizzaSauce)cboChooseSauce.SelectedItem;
            RefreshOrderFormSelections();
        }

        private void CboChooseSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPizza.Size = (PizzaSize)cboChooseSize.SelectedItem;
            RefreshOrderFormSelections();
        }

        private double GetChosenPizzaPrice()
        {
            double totalPrice = 0;

            foreach (PizzaTopping topping in chosenPizza.Toppings)
            {
                totalPrice += topping.Price;
            }
            totalPrice += chosenPizza.Size.Price;
            totalPrice += chosenPizza.Sauce.Price;
            totalPrice += chosenPizza.Dough.Price;

            return totalPrice;
        }

        private string GetToppingsString()
        {
            string toppingsString = "No toppings selected!";
            if (chosenPizza.Toppings.Count > 0)
            {
                toppingsString = "( ";
                int i = 0;
                foreach (PizzaTopping topping in chosenPizza.Toppings)
                {
                    toppingsString += topping.Name + ((i < chosenPizza.Toppings.Count - 1) ? ", " : "");
                    i++;
                }
                toppingsString += " )";
            }
            return toppingsString;
        }

        private void PizzaDataBinding()
        {
            cboChoosePizza.SelectedIndexChanged -= new System.EventHandler(CboChoosePizza_SelectedIndexChanged);
            cboChoosePizza.DataSource = pizzaOffer;
            cboChoosePizza.DisplayMember = "Name";
            cboChoosePizza.SelectedIndexChanged += new System.EventHandler(CboChoosePizza_SelectedIndexChanged);

            cboChooseSize.SelectedIndexChanged -= new System.EventHandler(CboChooseSize_SelectedIndexChanged);
            cboChooseSize.DataSource = pizzaSizesOffer;
            cboChooseSize.DisplayMember = "Name";
            cboChooseSize.SelectedIndexChanged += new System.EventHandler(CboChooseSize_SelectedIndexChanged);

            cboChooseDough.SelectedIndexChanged -= new System.EventHandler(CboChooseDough_SelectedIndexChanged);
            cboChooseDough.DataSource = pizzaDoughsOffers;
            cboChooseDough.DisplayMember = "Name";
            cboChooseDough.SelectedIndexChanged += new System.EventHandler(CboChooseDough_SelectedIndexChanged);

            cboChooseSauce.SelectedIndexChanged -= new System.EventHandler(CboChooseSauce_SelectedIndexChanged);
            cboChooseSauce.DataSource = pizzaSaucesOffer;
            cboChooseSauce.DisplayMember = "Name";
            cboChooseSauce.SelectedIndexChanged += new System.EventHandler(CboChooseSauce_SelectedIndexChanged);
        }
    }
}