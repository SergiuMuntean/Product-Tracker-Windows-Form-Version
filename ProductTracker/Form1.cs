using System;
using System.Data;
using System.Windows.Forms;

namespace ProductTracker
{
    public partial class Form1 : Form
    {
        DataTable inventory = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(InvetoryGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = InvetoryGridView.SelectedCells[0].RowIndex;
                inventory.Rows[selectedRowIndex]["Name"] = nameTextBox.Text;
                inventory.Rows[selectedRowIndex]["Price"] = priceTextBox.Text;
                inventory.Rows[selectedRowIndex]["Quantity"] = quantityTextBox.Text;
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a product to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InvetoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvetoryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Quantity");
            InvetoryGridView.DataSource = inventory;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String price = priceTextBox.Text;
            String quantity = quantityTextBox.Text;

            //Add the elements to grid
            inventory.Rows.Add(name, price, quantity);

            //Clear fields after save
            button1_Click(sender, e);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (InvetoryGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = InvetoryGridView.SelectedCells[0].RowIndex;

                // Remove the selected row from the DataTable
                inventory.Rows.RemoveAt(selectedRowIndex);

                // Clear fields after deletion
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
