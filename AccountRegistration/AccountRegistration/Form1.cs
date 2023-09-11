namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentInfoClass.Firstname = textBox4.Text.ToString();
            StudentInfoClass.Lastname = textBox3.Text.ToString();
            StudentInfoClass.Middlename = textBox5.Text.ToString();
            StudentInfoClass.Address = textBox6.Text.ToString();
            StudentInfoClass.Program = comboBox1.Text.ToString();

            StudentInfoClass.Age = Convert.ToInt32(textBox6.Text);
            StudentInfoClass.ContactNo = Convert.ToInt32(textBox7.Text);
            StudentInfoClass.StudentNo = Convert.ToInt32(textBox1.Text);

            MessageBox.Show(StudentInfoClass.Firstname);
        }

    }
}