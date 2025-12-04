using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region fields
        DataTable _dt;
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=(local)\r\n");
        SqlCommand _cmdSelect;
        SqlDataAdapter _da;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad(object sender, EventArgs e)
        {
            _cmdSelect = new SqlCommand("Select * from Student");
            _da = new SqlDataAdapter(_cmdSelect.CommandText, _con);
            _dt = new DataTable();
            _da.Fill(_dt);
            dgvData.DataSource = _dt;

        }

        
    }
}
