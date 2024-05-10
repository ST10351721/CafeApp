namespace CafeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalculationReciept CalcObj = new CalculationReciept();

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            //Transfers value of CafePro
            CafeProductCB.SelectedItem = CalcObj.Item;

            int ConvertedQuantity = Convert.ToInt32(QuantityTB.Text);

            ConvertedQuantity = CalcObj.Quantity;

          
        }

       
    }
}
