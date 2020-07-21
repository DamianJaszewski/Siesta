using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Siesta
{
    public partial class formMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public formMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Siesta.Properties.Settings.SiestaConnectionString"].ConnectionString;
        }
        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopularRecipes();
        }

        private void PopularRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))

            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listRecipes.DisplayMember = "Name";
                listRecipes.ValueMember = "Id";
                listRecipes.DataSource = recipeTable;
            }
           
        }
    }
}
