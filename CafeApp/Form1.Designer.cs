namespace CafeApp
{
    partial class Form1
    {

        public string getCafeProdCB()
        {

          string CafeProd = CafeProductCB.SelectedItem.ToString();

          return CafeProd;
        }
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
            CafeListLabel = new Label();
            ItemsLabel = new Label();
            CafeProductCB = new ComboBox();
            QuantityLabel = new Label();
            AddItemsButton = new Button();
            QuantityTB = new TextBox();
            GenRecieptButton = new Button();
            SuspendLayout();
            // 
            // CafeListLabel
            // 
            CafeListLabel.AutoSize = true;
            CafeListLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CafeListLabel.Location = new Point(328, 35);
            CafeListLabel.Name = "CafeListLabel";
            CafeListLabel.Size = new Size(162, 48);
            CafeListLabel.TabIndex = 0;
            CafeListLabel.Text = "Cafe List";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(177, 159);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(60, 25);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items:";
            // 
            // CafeProductCB
            // 
            CafeProductCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CafeProductCB.FormattingEnabled = true;
            CafeProductCB.Items.AddRange(new object[] { "Black Coffee", "Mocha", "Hot Chocolate", "Rooibos Tea", "Milk Coffee" });
            CafeProductCB.Location = new Point(328, 151);
            CafeProductCB.Name = "CafeProductCB";
            CafeProductCB.Size = new Size(182, 33);
            CafeProductCB.TabIndex = 3;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(177, 223);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(84, 25);
            QuantityLabel.TabIndex = 4;
            QuantityLabel.Text = "Quantity:";
            // 
            // AddItemsButton
            // 
            AddItemsButton.Location = new Point(550, 217);
            AddItemsButton.Name = "AddItemsButton";
            AddItemsButton.Size = new Size(125, 31);
            AddItemsButton.TabIndex = 5;
            AddItemsButton.Text = "Add Items";
            AddItemsButton.UseVisualStyleBackColor = true;
            // 
            // QuantityTB
            // 
            QuantityTB.Location = new Point(328, 217);
            QuantityTB.Name = "QuantityTB";
            QuantityTB.Size = new Size(182, 31);
            QuantityTB.TabIndex = 6;
            // 
            // GenRecieptButton
            // 
            GenRecieptButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenRecieptButton.Location = new Point(311, 298);
            GenRecieptButton.Name = "GenRecieptButton";
            GenRecieptButton.Size = new Size(235, 105);
            GenRecieptButton.TabIndex = 7;
            GenRecieptButton.Text = "Your Reciept";
            GenRecieptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenRecieptButton);
            Controls.Add(QuantityTB);
            Controls.Add(AddItemsButton);
            Controls.Add(QuantityLabel);
            Controls.Add(CafeProductCB);
            Controls.Add(ItemsLabel);
            Controls.Add(CafeListLabel);
            Name = "Form1";
            Text = "Cafe Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CafeListLabel;
        private Label ItemsLabel;
        private ComboBox CafeProductCB;
        private Label QuantityLabel;
        private Button AddItemsButton;
        private TextBox QuantityTB;
        private Button GenRecieptButton;
    }
}
