using PayrollSystem.Forms.Employees;
using PayrollSystem.Logic;
using PayrollSystem.Tools;
using SystemSale.Forms.Users;

namespace PayrollSystem.Forms.Users
{
    public partial class FrmViewEmployees : Form
    {
        public string? IdEmployee { get; private set; }
        public string? NameEmployee { get; private set; }
        public string? LastName { get; private set; }
        public string? NumberDocument { get; private set; }
        public string? Role { get; private set; }
        public string? Salary { get; private set; }

        public FrmViewEmployees()
        {
            InitializeComponent();
        }

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if (DataList.Rows.Count > 0)
            {
                this.DataList.Columns[1].Visible = false;
                this.DataList.Columns[16].Visible = false;
            }
        }

        #endregion

        #region Method ShowEmployees DataGridView DataList
        private void ShowEmployees()
        {
            this.DataList.DataSource = LEmployee.ShowEmployees();
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName DataGridView DataList
        private void SearchName()
        {
            this.DataList.DataSource = LEmployee.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchNNumberDocument DataGridView DataList
        private void SearchNNumberDocument()
        {
            this.DataList.DataSource = LEmployee.SearchNNumberDocument(Convert.ToString(TxtSearch.Text));
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion


        #region FrmEmployees Load Event
        private void FrmViewEmployees_Load(object sender, EventArgs e)
        {
            this.ShowEmployees();
        }

        #endregion

        #region Search Textbox TextChanged Event
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (CbxSearch.Text.Equals("Name"))
            {
                this.SearchName();
            }
            else if (CbxSearch.Text.Equals("Document"))
            {
                this.SearchNNumberDocument();
            }
        }

        #endregion

        #region Search Textbox KeyPress Event
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbxSearch.Text.Equals("Name"))
            {
                Validation.OnlyLetters(e);
            }
            else if (CbxSearch.Text.Equals("Document"))
            {
                Validation.OnlyNumbers(e);
            }
        }

        #endregion

        #region DataList DataGridView DoubleClick Event
        private void DataList_DoubleClick(object sender, EventArgs e)
        {
            IdEmployee = (Convert.ToString(DataList.CurrentRow.Cells["IdEmployee"].Value));
            //Employee = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value) + " " + Convert.ToString(DataList.CurrentRow.Cells["LastName"].Value);
            NameEmployee = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            LastName = Convert.ToString(DataList.CurrentRow.Cells["LastName"].Value);
            NumberDocument = Convert.ToString(DataList.CurrentRow.Cells["NumberDocument"].Value);
            Role = Convert.ToString(DataList.CurrentRow.Cells["Role"].Value);
            Salary = Convert.ToString(DataList.CurrentRow.Cells["Salary"].Value);
            this.Close();
            
        }

        #endregion

    }
}
