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
            this.siestaDataSet4 = new Siesta.SiestaDataSet();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lstRecipe1 = new System.Windows.Forms.ListBox();
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
            this.lblRecipe.Location = new System.Drawing.Point(33, 43);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(123, 28);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipe";
            // 
            // lstRecipe1
            // 
            this.lstRecipe1.Location = new System.Drawing.Point(36, 74);
            this.lstRecipe1.Name = "lstRecipe1";
            this.lstRecipe1.Size = new System.Drawing.Size(120, 95);
            this.lstRecipe1.TabIndex = 0;
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.lstRecipe1);
            this.Controls.Add(this.lblRecipe);
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siestaDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiestaDataSet siestaDataSet4;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.ListBox lstRecipe1;
    }
}

