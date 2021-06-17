using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SelfService
{
    public partial class Form1 : Form
    {
        int allTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PilihShirt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgShirts.CurrentRow;
            dgCart.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
            allTotal += int.Parse(row.Cells[3].Value.ToString());
        }

        private void btn_PilihPants_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgPants.CurrentRow;
            dgCart.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
            allTotal += int.Parse(row.Cells[3].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var shi = new ShirtModel())
            {
                var query = from shirt in shi.Tables select shirt;
                foreach (var item in shi.Tables)
                {
                    dgShirts.Rows.Add(item.brand, item.type, item.size, item.price, item.stock);
                }
            }
            using (var pan = new PantsModel())
            {
                foreach (var item in pan.Tables)
                {
                    dgPants.Rows.Add(item.brand, item.type, item.size, item.price, item.stock);
                }
            }
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "************************************************************************\n";
            txtResult.Text += "***                                 Apparel Store                                 ***\n";
            txtResult.Text += "***                                    RECEIPT                                    ***\n";
            txtResult.Text += "************************************************************************\n\n";

            foreach (DataGridViewRow row in dgCart.Rows)
            {
                txtResult.Text += row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString() + "\t\t" + row.Cells[2].Value.ToString() + "\t\t" + row.Cells[3].Value.ToString() + "\n";
            }

            txtResult.Text += "-----------------------------------------------------------------------------------------------\n";
            txtResult.Text += "Total:\t\t\t\t\t" + allTotal.ToString();

            Bitmap qr = new Bitmap(30, 30);
            QRManager.Generate(allTotal, out qr);
            pbQR.BackgroundImage = qr;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgCart.CurrentRow;
            dgCart.Rows.Remove(row);
            allTotal -= int.Parse(row.Cells[3].Value.ToString());
        }
    }
}
