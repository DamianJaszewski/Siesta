namespace Siesta
{
    partial class formMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAddRecipe;
            this.siestaDataSet4 = new Siesta.SiestaDataSet();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            btnAddRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siestaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // siestaDataSet4
            // 
            this.siestaDataSet4.DataSetName = "SiestaDataSet";
            this.siestaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRecipe
            // 
            this.lblRecipe.Location = new System.Drawing.Point(33, 83);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(123, 15);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipe";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // lstRecipe
            // 
            this.lstRecipe.Location = new System.Drawing.Point(36, 101);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(120, 95);
            this.lstRecipe.TabIndex = 0;
            this.lstRecipe.SelectedIndexChanged += new System.EventHandler(this.lstRecipe_SelectedIndexChanged);
            // 
            // lstIngredient
            // 
            this.lstIngredient.Location = new System.Drawing.Point(165, 101);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(120, 95);
            this.lstIngredient.TabIndex = 1;
            this.lstIngredient.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblIngredient
            // 
            this.lblIngredient.Location = new System.Drawing.Point(162, 83);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(123, 28);
            this.lblIngredient.TabIndex = 2;
            this.lblIngredient.Text = "Ingredients";
            this.lblIngredient.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new System.Drawing.Point(36, 44);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            btnAddRecipe.TabIndex = 3;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(36, 18);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeName.TabIndex = 4;
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(btnAddRecipe);
            this.Controls.Add(this.lstIngredient);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.lblRecipe);
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siestaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiestaDataSet siestaDataSet4;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.ListBox lstIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.TextBox txtRecipeName;
    }
}

