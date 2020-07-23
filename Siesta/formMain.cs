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
        private void formMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateAllIngredients();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))

            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                lstRecipe.DisplayMember = "Name";
                lstRecipe.ValueMember = "Id";
                lstRecipe.DataSource = recipeTable;
            }
        }
        private void PopulateAllIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))

            {
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstAllIngredients.DisplayMember = "Name";
                lstAllIngredients.ValueMember = "Id";
                lstAllIngredients.DataSource = ingredientTable;
            }
        }
        private void PopulateIngredient()
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipeIndex b ON a.Id=b.IngredientId " +
                "WHERE b.RecipeId = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command)) 

            {
                command.Parameters.AddWithValue("@RecipeId", lstRecipe.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstIngredient.DisplayMember = "Name";
                lstIngredient.ValueMember = "Id";
                lstIngredient.DataSource = ingredientTable;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredient();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'blah blah')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);

                command.ExecuteNonQuery();
            }
            PopulateRecipes();
        }

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE id = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", lstRecipe.SelectedValue);
                command.ExecuteNonQuery();

            }
            PopulateRecipes();
        }

        private void lstAllIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIndex VALUES (@RecipeId, @IngredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", lstRecipe.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", lstAllIngredients.SelectedValue);

                command.ExecuteNonQuery();
            }
            PopulateRecipes();
        }
    }
}
