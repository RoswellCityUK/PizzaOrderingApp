namespace PizzaOrderingApp
{
    public partial class EditToppings : Form
    {
        private List<PizzaTopping> temporaryToppingsList;
        private BindingSource bindingSource = new BindingSource();

        public EditToppings()
        {
            InitializeComponent();
            MainPizzaOrderApp.toppingsEditFormOpen = true;
            temporaryToppingsList = new List<PizzaTopping>(MainPizzaOrderApp.chosenPizza.Toppings);

            bindingSource.DataSource = temporaryToppingsList;
            lstToppings.DataSource = bindingSource;
            lstToppings.DisplayMember = "Name";
            GetToppingsTotalPrice();
        }

        private void AddTopping(string topping)
        {
            MainPizzaOrderApp owner = (MainPizzaOrderApp)this.Owner;
            var test = owner.pizzaToppingsOffer.Find(x => x.Name == topping);
            if (test != null) { temporaryToppingsList.Add(test); }
            GetToppingsTotalPrice();
            bindingSource.ResetBindings(false);
        }

        private void btnAddBeef_Click(object sender, EventArgs e)
        {
            AddTopping("Beef");
        }

        private void btnAddBlueCheese_Click(object sender, EventArgs e)
        {
            AddTopping("Blue Cheese");
        }

        private void btnAddCarrots_Click(object sender, EventArgs e)
        {
            AddTopping("Carrots");
        }

        private void btnAddCheddar_Click(object sender, EventArgs e)
        {
            AddTopping("Cheddar");
        }

        private void btnAddChicken_Click(object sender, EventArgs e)
        {
            AddTopping("Chicken");
        }

        private void btnAddFetaCheese_Click(object sender, EventArgs e)
        {
            AddTopping("Feta Cheese");
        }

        private void btnAddGoatCheese_Click(object sender, EventArgs e)
        {
            AddTopping("Goat Cheese");
        }

        private void btnAddHam_Click(object sender, EventArgs e)
        {
            AddTopping("Ham");
        }

        private void btnAddOlives_Click(object sender, EventArgs e)
        {
            AddTopping("Olives");
        }

        private void btnAddPepper_Click(object sender, EventArgs e)
        {
            AddTopping("Pepper");
        }

        private void btnAddPepperoni_Click(object sender, EventArgs e)
        {
            AddTopping("Pepperoni");
        }

        private void btnAddPineapple_Click(object sender, EventArgs e)
        {
            AddTopping("Pineapple");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            temporaryToppingsList.Clear();
            GetToppingsTotalPrice();
            bindingSource.ResetBindings(false);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            PizzaTopping selectedTopping = (PizzaTopping)lstToppings.SelectedItem;
            temporaryToppingsList.Remove(selectedTopping);
            GetToppingsTotalPrice();
            bindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainPizzaOrderApp.toppingsEditFormOpen = false;
            MainPizzaOrderApp.chosenPizza.Toppings = temporaryToppingsList;
            MainPizzaOrderApp owner = (MainPizzaOrderApp)this.Owner;
            owner.RefreshOrderFormSelections();
            this.Close();
        }

        private void toppingEditForm_Closing(object sender, FormClosingEventArgs e)
        {
            MainPizzaOrderApp.toppingsEditFormOpen = false;
        }

        private void GetToppingsTotalPrice()
        {
            double totalPrice = 0;
            if (temporaryToppingsList.Count > 0)
            {
                foreach (PizzaTopping topping in temporaryToppingsList)
                {
                    totalPrice += topping.Price;
                }
            }
            lblToppingsTotalAmount.Text = totalPrice.ToString("C");
        }
    }
}