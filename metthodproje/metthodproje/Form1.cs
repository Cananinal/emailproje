namespace metthodproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string schoolNumber = textBox3.Text;

            try
            {
                string emailAddress = firstName.GenerateEmailAddress(lastName, schoolNumber);

                MessageBox.Show($"Oluþturulan E-posta Adresi: {emailAddress}", "E-posta Adresi Oluþturuldu");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata");
            }
        }
    }
    public static class StringExtensions
    {
        public static string GenerateEmailAddress(this string firstName, string lastName, string schoolNumber)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(schoolNumber))
            {
                throw new ArgumentException("First name, last name, and school number cannot be null or empty.");
            }

            string formattedFirstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
            string formattedLastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

            string emailAddress = $"{formattedFirstName}{formattedLastName}_{schoolNumber}@ostimteknik.edu.tr";

            return emailAddress;
        }
    }
}