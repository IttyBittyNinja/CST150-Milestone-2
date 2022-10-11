namespace _ABRAMS__CST_150_Milestone_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* The GetItemData method accepts a Item object as an argument.
         * It assigns the data entered by the user to the object's properties. */
        private void GetItemData(Inventory Item)
        {
            // Temporary variable to hold the code, cost, and quantity.
            int code;
            int cost;
            int quantity;

            // Get item's name.
            Item.Name = nameInput.Text;

            // Get item's code.
            Item.Category = categoryInput.Text;

            // Get item's code.
            if (int.TryParse(codeInput.Text, out code))
            {
                Item.Code = code;
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid Code.");
            }

            // Get item's cost.
            if (int.TryParse(costInput.Text, out cost))
            {
                Item.Cost = cost;
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid Price.");
            }

            // Get item's quantity.
            if (int.TryParse(quantityInput.Text, out quantity))
            {
                Item.Quantity = quantity;
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid Quantity.");
            }

        }
        
        private void addnewButton_Click(object sender, EventArgs e)
        {
            // Create Inventory object.
            Inventory item = new Inventory();

            // Get the item data.
            GetItemData(item);

            // Display the item data.
            itemDisplayOutput.Items.Add(item.Code + "         " + item.Name + "         $" + item.Cost + "         " + item.Quantity + "         " + "         " + item.Category);

            // Clear the TextBox controls.
            codeInput.Text = "";
            nameInput.Text = "";
            costInput.Text = "";
            quantityInput.Text = "";
            categoryInput.Text = "";

            // Reset the focus.
            codeInput.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBox controls.
            codeInput.Text = "";
            nameInput.Text = "";
            costInput.Text = "";
            quantityInput.Text = "";
            categoryInput.Text = "";

            // Reset the focus.
            codeInput.Focus();
        }
    }
}