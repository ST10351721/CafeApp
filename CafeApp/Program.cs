namespace CafeApp
{

    //ST10351721
    //Ethan Shaun Moodley
    //PROG Ice task 3


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //int Quant = Convert
            //CafeProductCB.getSelected() , QuantityTB.
            Console.WriteLine();

        }
    }

    public class CalculationReciept()
    {
        //2 Datafields hold values to be stored in the array
        public string Item {  get; set; }
        public int Quantity { get; set; }

        
        private string[] arrHoldCustomerOrder = new string[100];
        private int currentIndex = 0;

        public void AddItem(string item,int quantity)
        {
            arrHoldCustomerOrder[currentIndex] = $"{item} - Quantity: {quantity}";
            currentIndex++;
        }

        public string DisplayRecipt()
        {
            string receipt = "Receipt:\n\n";
            for(int i = 0;i < currentIndex;i++)
            {
                receipt += arrHoldCustomerOrder[i] + "\n";
            }

            return receipt;

        }
       
       
    }





}