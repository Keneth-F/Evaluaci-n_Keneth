using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Evaluación_Keneth.Forms
{
    public partial class Gestion : MaterialForm
    {
        string[] products = new string[] { "Lip gloss", "Iluminador", "Correctot" };
        string[] customers = new string[1];
        int[] units = new int[1];
        double[] prices = new double[1];
        public Gestion()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            //Set user

            CbProducts.Items.AddRange(products);
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            if (!IsFormFullFilled())
            {
                ToggleLabel("Debes llenar el formulario");
                return;
            }
            var product = CbProducts.SelectedItem.ToString();
            var customer = TxtCustomer.Text;
            var unitsText = TxtUnits.Text;
            var priceText = TxtPrice.Text;
            if (!IsNumber(TxtPrice.Text))
            {
                ToggleLabel("El precio no es valido");
                return;
            }
            if (!IsNumber(TxtUnits.Text))
            {
                ToggleLabel("La cantidad no es valida");
                return;
            }
            var _units = int.Parse(unitsText);
            var price = Double.Parse(priceText);
            Array.Resize(ref products, products.Length + 1);
            Array.Resize(ref units, units.Length + 1);
            Array.Resize(ref prices, prices.Length + 1);
            products[products.Length - 1] = product;
            units[units.Length - 1] = _units;
            prices[prices.Length - 1] = price;
            TxtFinalTotal.Text = CalculateTotal(_units, price);
        }

        private string CalculateTotal(int units, double price)
        {
            return Double.Parse(TxtFinalTotal.Text) + (units * price) + "";
        }

        private bool IsNumber(string text)
        {
            return Double.TryParse(text, out _);
        }

        private bool IsFormFullFilled()
        {
            return !(string.IsNullOrEmpty(TxtCustomer.Text)
                 || CbProducts.SelectedItem == null);

        }
        private void ToggleLabel(string text)
        {
            LblErrors.Visible = !LblErrors.Visible;
            LblErrors.Text = text;
        }

        private void TxtUnits_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUnits.Text))
            {
                TxtUnits.Text = "";
                return;
            }
            if (!int.TryParse(TxtUnits.Text, out _))
            {
                TxtUnits.Text = TxtUnits.Text.Substring(0, TxtUnits.Text.Length - 1);
            }
            if (!IsNumber(TxtPrice.Text))
            {
                ToggleLabel("El precio no es valido");
                return;
            }
            var unitsText = TxtUnits.Text;
            var priceText = TxtPrice.Text;
            var _units = int.Parse(unitsText);
            var price = Double.Parse(priceText);
            TxtTotal.Text = CalculateTotal(_units, price);
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                TxtPrice.Text = "";
                return;
            }
            if (!int.TryParse(TxtPrice.Text, out _))
            {
                TxtPrice.Text = TxtPrice.Text.Substring(0, TxtPrice.Text.Length - 1);
            }
            if (!IsNumber(TxtUnits.Text))
            {
                ToggleLabel("La cantidad no es valida");
                return;
            }
            var unitsText = TxtUnits.Text;
            var priceText = TxtPrice.Text;
            var _units = int.Parse(unitsText);
            var price = Double.Parse(priceText);
            TxtTotal.Text= CalculateTotal(_units, price);
        }

        private void BtnSell_Leave(object sender, EventArgs e)
        {
            ToggleLabel("");
        }
    }
}
