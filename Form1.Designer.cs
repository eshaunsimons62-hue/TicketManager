namespace TicketManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btnResolve = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();

            // ── Form ──
            this.Text = "IT Ticket Manager — Netrio";
            this.Size = new System.Drawing.Size(900, 650);
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);

            // ── Header Panel ──
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Text = "🖥  IT Ticket Manager";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── Form Panel ──
            this.pnlForm.Size = new System.Drawing.Size(860, 160);
            this.pnlForm.Location = new System.Drawing.Point(20, 75);
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Padding = new System.Windows.Forms.Padding(15);

            // ── Labels ──
            this.lblName.Text = "Client Name";
            this.lblName.Location = new System.Drawing.Point(15, 15);
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            this.lblIssue.Text = "Issue";
            this.lblIssue.Location = new System.Drawing.Point(15, 60);
            this.lblIssue.Size = new System.Drawing.Size(100, 20);
            this.lblIssue.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            this.lblSeverity.Text = "Severity";
            this.lblSeverity.Location = new System.Drawing.Point(500, 15);
            this.lblSeverity.Size = new System.Drawing.Size(100, 20);
            this.lblSeverity.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // ── Input Fields ──
            this.txtName.Location = new System.Drawing.Point(15, 35);
            this.txtName.Size = new System.Drawing.Size(460, 28);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            this.txtIssue.Location = new System.Drawing.Point(15, 80);
            this.txtIssue.Size = new System.Drawing.Size(460, 28);
            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssue.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            this.cmbSeverity.Location = new System.Drawing.Point(500, 35);
            this.cmbSeverity.Size = new System.Drawing.Size(160, 28);
            this.cmbSeverity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSeverity.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });
            this.cmbSeverity.SelectedIndex = 0;

            // ── Buttons ──
            this.btnSubmit.Text = "Submit Ticket";
            this.btnSubmit.Location = new System.Drawing.Point(500, 80);
            this.btnSubmit.Size = new System.Drawing.Size(130, 35);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(30, 60, 114);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnResolve.Text = "✔ Mark Resolved";
            this.btnResolve.Location = new System.Drawing.Point(640, 80);
            this.btnResolve.Size = new System.Drawing.Size(140, 35);
            this.btnResolve.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnResolve.ForeColor = System.Drawing.Color.White;
            this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolve.FlatAppearance.BorderSize = 0;
            this.btnResolve.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── Add to form panel ──
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.lblIssue);
            this.pnlForm.Controls.Add(this.lblSeverity);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.txtIssue);
            this.pnlForm.Controls.Add(this.cmbSeverity);
            this.pnlForm.Controls.Add(this.btnSubmit);
            this.pnlForm.Controls.Add(this.btnResolve);

            // ── Ticket Grid ──
            this.dgvTickets.Location = new System.Drawing.Point(20, 250);
            this.dgvTickets.Size = new System.Drawing.Size(860, 340);
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.EnableHeadersVisualStyles = false;
            this.dgvTickets.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 60, 114);
            this.dgvTickets.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTickets.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvTickets.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.dgvTickets.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 60, 114);
            this.dgvTickets.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // ── Add everything to Form ──
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.dgvTickets);
        }
    }
}