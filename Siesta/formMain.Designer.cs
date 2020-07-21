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
            this.labelRecipes = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelRecipes
            // 
            this.labelRecipes.AutoSize = true;
            this.labelRecipes.Location = new System.Drawing.Point(22, 26);
            this.labelRecipes.Name = "labelRecipes";
            this.labelRecipes.Size = new System.Drawing.Size(46, 13);
            this.labelRecipes.TabIndex = 0;
            this.labelRecipes.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(25, 57);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 95);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.labelRecipes);
            this.Name = "formMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiestaDataSet siestaDataSet;
        private SiestaDataSet siestaDataSet1;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox lisRecipes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label asdf;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.ListBox listRecipes;
    }
}

