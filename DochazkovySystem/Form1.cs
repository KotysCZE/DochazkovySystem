namespace DochazkovySystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void arrival_Click(object sender, EventArgs e)
        {
            DatabaseOfActions databaseOfActions = new DatabaseOfActions();

            MessageBox.Show(databaseOfActions.AddArrival(employeeNumberTextBox.Text));
        }
        private void leave_Click(object sender, EventArgs e)
        {
            DatabaseOfActions databaseOfActions = new DatabaseOfActions();
            MessageBox.Show(databaseOfActions.AddLeave(employeeNumberTextBox.Text));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}