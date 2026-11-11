namespace Convene
{
    public partial class Convene_Form : Form
    {
        public Convene_Form()
        {
            InitializeComponent();
            SetupMockCalendar();

            proposalsControl1.SendToBack();
            calendarControl1.SendToBack();
            proposalsControl1.Visible = false;
            calendarControl1.Visible = false;

        }

        private void SetupMockCalendar()
        {
            // 1. Strip away the default database styling
            dgv_mockhomepagcalendar.AllowUserToAddRows = false;
            dgv_mockhomepagcalendar.AllowUserToDeleteRows = false;
            dgv_mockhomepagcalendar.AllowUserToResizeColumns = false;
            dgv_mockhomepagcalendar.AllowUserToResizeRows = false;
            dgv_mockhomepagcalendar.RowHeadersVisible = false;
            dgv_mockhomepagcalendar.BackgroundColor = Color.White;
            dgv_mockhomepagcalendar.BorderStyle = BorderStyle.None;
            dgv_mockhomepagcalendar.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv_mockhomepagcalendar.GridColor = Color.FromArgb(224, 224, 224);

            // Auto-stretch columns to fit the screen evenly
            dgv_mockhomepagcalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable the ugly blue selection highlight
            dgv_mockhomepagcalendar.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv_mockhomepagcalendar.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Center text in cells
            dgv_mockhomepagcalendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_mockhomepagcalendar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 2. Add the 7 Days of the Week
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            foreach (string day in days)
            {
                dgv_mockhomepagcalendar.Columns.Add(day, day);
            }

            // 3. Add blank rows and make them tall to look like a calendar
            dgv_mockhomepagcalendar.Rows.Add(4);
            foreach (DataGridViewRow row in dgv_mockhomepagcalendar.Rows)
            {
                row.Height = 80;
            }

            // 4. Paint the fake time blocks!
            // Block 1: Amber (Pending Proposal) on Wednesday (Column index 2)
            dgv_mockhomepagcalendar.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(253, 237, 206);
            dgv_mockhomepagcalendar.Rows[1].Cells[2].Style.ForeColor = Color.Black;
            dgv_mockhomepagcalendar.Rows[1].Cells[2].Value = "Team Meeting\n10:00 AM";

            // Block 2: Deep Purple/Blue (Locked Task) on Friday (Column index 4)
            dgv_mockhomepagcalendar.Rows[2].Cells[5].Style.BackColor = Color.FromArgb(67, 56, 202);
            dgv_mockhomepagcalendar.Rows[2].Cells[5].Style.ForeColor = Color.White;
            dgv_mockhomepagcalendar.Rows[2].Cells[5].Value = "Lunch with family\n1:00 PM";

        }



        private void Convene_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_convene_Click(object sender, EventArgs e)
        {

        }

        private void lb_workspace_MouseHover(object sender, EventArgs e)
        {
            lb_workspace.ForeColor = Color.FromArgb(245, 246, 251);
        }

        private void lb_workspace_MouseLeave(object sender, EventArgs e)
        {
            lb_workspace.ForeColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendarControl1.Hide();
            proposalsControl1.Hide();

        }

        private void btn_homepage_MouseHover(object sender, EventArgs e)
        {
            btn_homepage.ForeColor = Color.FromArgb(245, 246, 251);
        }

        private void btn_homepage_MouseLeave(object sender, EventArgs e)
        {
            btn_homepage.ForeColor = Color.Gray;
        }

        private void SidebarHover(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            current.ForeColor = Color.FromArgb(245, 246, 251);

        }


        private void SidebarLeave(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            current.ForeColor = Color.Gray;

        }

        private void lb_voteswaitingtext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            calendarControl1.Show();
            calendarControl1.BringToFront();
            proposalsControl1.Hide();
        }

        private void btn_proposals_Click(object sender, EventArgs e)
        {
            proposalsControl1.Show();
            proposalsControl1.BringToFront();
            calendarControl1.Hide();

        }

        private void proposalsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
