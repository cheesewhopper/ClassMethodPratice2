namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;
        // partial : 클래스의 정의가 다수 되어있다
        public Form1()
        {
            InitializeComponent();
        }

        private void CusDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {

            //DateTime birthday = new DateTime(2000, 1, 1);

            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAdress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDiscription.Text;

            CustomerArrayIndex++;

            /*Cus1 = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            Cus1.Address = CusNewAdress.Text;
            Cus1.Description = CusNewDiscription.Text;

            CusFullName.Text = Cus1.FullName;
            CusAge.Text = Cus1.Age.ToString();
            CusAdress.Text = Cus1.Address;
            CusDescription.Text = Cus1.Description;
            CusIsQualified.Text = Cus1.IsQualified.ToString();
           */

            // CusLastName.Text =cus.LastName;
            // bool test = cus.IsQualified;

            /*DateTime date = new DateTime(2022, 6, 10);
            DateTime current = DateTime.Now;*/

        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAdress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}