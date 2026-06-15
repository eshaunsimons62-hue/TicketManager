namespace TicketManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.Initialize();
            LoadTickets();

            btnSubmit.Click += BtnSubmit_Click;
            btnResolve.Click += BtnResolve_Click;
        }

        private void LoadTickets()
        {
            var tickets = Database.GetAllTickets();
            dgvTickets.DataSource = tickets;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtIssue.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database.AddTicket(txtName.Text, txtIssue.Text, cmbSeverity.Text);
            txtName.Text = "";
            txtIssue.Text = "";
            cmbSeverity.SelectedIndex = 0;
            LoadTickets();
        }

        private void BtnResolve_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvTickets.SelectedRows[0].Cells["Id"].Value;
            Database.ResolveTicket(id);
            LoadTickets();
        }
    }
}