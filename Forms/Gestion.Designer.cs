namespace Evaluación_Keneth.Forms
{
    partial class Gestion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFinalTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.DtgvData = new System.Windows.Forms.DataGridView();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.BtnSell = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtUnits = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtCustomer = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CbProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblErrors = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvData)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtFinalTotal);
            this.panel1.Controls.Add(this.DtgvData);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.LblUser);
            this.panel1.Controls.Add(this.LblErrors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 510);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total:";
            // 
            // TxtFinalTotal
            // 
            this.TxtFinalTotal.AnimateReadOnly = false;
            this.TxtFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFinalTotal.Depth = 0;
            this.TxtFinalTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFinalTotal.LeadingIcon = null;
            this.TxtFinalTotal.Location = new System.Drawing.Point(606, 456);
            this.TxtFinalTotal.MaxLength = 50;
            this.TxtFinalTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFinalTotal.Multiline = false;
            this.TxtFinalTotal.Name = "TxtFinalTotal";
            this.TxtFinalTotal.ReadOnly = true;
            this.TxtFinalTotal.Size = new System.Drawing.Size(165, 50);
            this.TxtFinalTotal.TabIndex = 12;
            this.TxtFinalTotal.Text = "0";
            this.TxtFinalTotal.TrailingIcon = null;
            // 
            // DtgvData
            // 
            this.DtgvData.BackgroundColor = System.Drawing.Color.Azure;
            this.DtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProducto,
            this.CUnidades,
            this.CPrecio,
            this.CTotal});
            this.DtgvData.Location = new System.Drawing.Point(14, 223);
            this.DtgvData.Name = "DtgvData";
            this.DtgvData.Size = new System.Drawing.Size(757, 227);
            this.DtgvData.TabIndex = 8;
            // 
            // CProducto
            // 
            this.CProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.ReadOnly = true;
            // 
            // CUnidades
            // 
            this.CUnidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUnidades.HeaderText = "Unidades";
            this.CUnidades.Name = "CUnidades";
            this.CUnidades.ReadOnly = true;
            // 
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // CTotal
            // 
            this.CTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.BtnSell);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.TxtPrice);
            this.materialCard1.Controls.Add(this.TxtTotal);
            this.materialCard1.Controls.Add(this.TxtUnits);
            this.materialCard1.Controls.Add(this.TxtCustomer);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.CbProducts);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(757, 156);
            this.materialCard1.TabIndex = 2;
            // 
            // BtnSell
            // 
            this.BtnSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSell.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSell.Depth = 0;
            this.BtnSell.HighEmphasis = true;
            this.BtnSell.Icon = global::Evaluación_Keneth.Properties.Resources.shopping_cart;
            this.BtnSell.Location = new System.Drawing.Point(544, 102);
            this.BtnSell.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSell.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSell.Size = new System.Drawing.Size(188, 36);
            this.BtnSell.TabIndex = 11;
            this.BtnSell.Text = "Procesar Compra";
            this.BtnSell.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSell.UseAccentColor = false;
            this.BtnSell.UseVisualStyleBackColor = true;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            this.BtnSell.Leave += new System.EventHandler(this.BtnSell_Leave);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(541, 33);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Precio";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(276, 102);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Total";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(276, 33);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Unidades";
            // 
            // TxtPrice
            // 
            this.TxtPrice.AnimateReadOnly = false;
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrice.Depth = 0;
            this.TxtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPrice.LeadingIcon = global::Evaluación_Keneth.Properties.Resources.currency_cent;
            this.TxtPrice.Location = new System.Drawing.Point(592, 16);
            this.TxtPrice.MaxLength = 50;
            this.TxtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPrice.Multiline = false;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(150, 50);
            this.TxtPrice.TabIndex = 5;
            this.TxtPrice.Text = "";
            this.TxtPrice.TrailingIcon = null;
            this.TxtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.AnimateReadOnly = false;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Depth = 0;
            this.TxtTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTotal.LeadingIcon = null;
            this.TxtTotal.Location = new System.Drawing.Point(349, 90);
            this.TxtTotal.MaxLength = 50;
            this.TxtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTotal.Multiline = false;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(150, 50);
            this.TxtTotal.TabIndex = 4;
            this.TxtTotal.Text = "";
            this.TxtTotal.TrailingIcon = null;
            // 
            // TxtUnits
            // 
            this.TxtUnits.AnimateReadOnly = false;
            this.TxtUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUnits.Depth = 0;
            this.TxtUnits.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUnits.LeadingIcon = null;
            this.TxtUnits.Location = new System.Drawing.Point(349, 19);
            this.TxtUnits.MaxLength = 50;
            this.TxtUnits.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUnits.Multiline = false;
            this.TxtUnits.Name = "TxtUnits";
            this.TxtUnits.Size = new System.Drawing.Size(150, 50);
            this.TxtUnits.TabIndex = 3;
            this.TxtUnits.Text = "";
            this.TxtUnits.TrailingIcon = null;
            this.TxtUnits.TextChanged += new System.EventHandler(this.TxtUnits_TextChanged);
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.AnimateReadOnly = false;
            this.TxtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCustomer.Depth = 0;
            this.TxtCustomer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCustomer.LeadingIcon = null;
            this.TxtCustomer.Location = new System.Drawing.Point(90, 90);
            this.TxtCustomer.MaxLength = 50;
            this.TxtCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCustomer.Multiline = false;
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(150, 50);
            this.TxtCustomer.TabIndex = 2;
            this.TxtCustomer.Text = "";
            this.TxtCustomer.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cliente";
            // 
            // CbProducts
            // 
            this.CbProducts.AutoResize = false;
            this.CbProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbProducts.Depth = 0;
            this.CbProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbProducts.DropDownHeight = 174;
            this.CbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProducts.DropDownWidth = 121;
            this.CbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbProducts.FormattingEnabled = true;
            this.CbProducts.IntegralHeight = false;
            this.CbProducts.ItemHeight = 43;
            this.CbProducts.Location = new System.Drawing.Point(90, 17);
            this.CbProducts.MaxDropDownItems = 4;
            this.CbProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.CbProducts.Name = "CbProducts";
            this.CbProducts.Size = new System.Drawing.Size(150, 49);
            this.CbProducts.StartIndex = 0;
            this.CbProducts.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Producto";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(3, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(89, 20);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Usuario: sa";
            // 
            // LblErrors
            // 
            this.LblErrors.AutoSize = true;
            this.LblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrors.ForeColor = System.Drawing.Color.Red;
            this.LblErrors.Location = new System.Drawing.Point(11, 204);
            this.LblErrors.Name = "LblErrors";
            this.LblErrors.Size = new System.Drawing.Size(36, 16);
            this.LblErrors.TabIndex = 7;
            this.LblErrors.Text = "Error";
            this.LblErrors.Visible = false;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 577);
            this.Controls.Add(this.panel1);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvData)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox CbProducts;
        private System.Windows.Forms.Label LblUser;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label LblErrors;
        private MaterialSkin.Controls.MaterialTextBox TxtPrice;
        private MaterialSkin.Controls.MaterialTextBox TxtTotal;
        private MaterialSkin.Controls.MaterialTextBox TxtUnits;
        private MaterialSkin.Controls.MaterialTextBox TxtCustomer;
        private System.Windows.Forms.DataGridView DtgvData;
        private MaterialSkin.Controls.MaterialButton BtnSell;
        private MaterialSkin.Controls.MaterialTextBox TxtFinalTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
    }
}