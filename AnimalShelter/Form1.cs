namespace AnimalShelter
{
    public partial class Form1 : Form
    {
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
            DateTime birthday = new DateTime(2000, 1, 1);
            Customer cus = new Customer("Ian", "Na", birthday);
            cus.Address = "123 wilshire Blvd.";

            CusFullName.Text =cus.FullName;
           // CusLastName.Text =cus.LastName;
            CusAge.Text = cus.Age.ToString();
            CusAdress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
           // bool test = cus.IsQualified;

            /*DateTime date = new DateTime(2022, 6, 10);
            DateTime current = DateTime.Now;*/
            
        }
    }
}