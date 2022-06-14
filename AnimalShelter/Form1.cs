using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        //public Customer[] CustomerArray = new Customer[10];
        //public int CustomerArrayIndex = 0;
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

            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAdress.Text;
            cus.Description = CusNewDiscription.Text;

            /*CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAdress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDiscription.Text;*/ 
            /*CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);
            CustomerArrayIndex++;
            */
            CustomerList.Items.Add(cus.FirstName);
            Customers.Add(cus);

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

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            for (int i = 0; i < CustomerArrayIndex; i++)
            {
                if (CustomerArray[i].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[i]);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(3);

            arrayList.Insert(2, 2);
            arrayList.Remove(2);
            arrayList.RemoveAt(3);


            int sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                int num = (int)arrayList[i];
                sum += num;
            }

            List<int> intlist = new List<int>();
            intlist.Add(1);
            intlist.Add(2);

            int sum2 = 0;
            for (int i = 0; i < intlist.Count; i++)
            {
                int value = intlist[i];
                sum2 += value;
            }

            foreach (int value in intlist)
            {
                sum += value;
            }

        }
    }
}