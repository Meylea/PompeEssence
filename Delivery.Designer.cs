
namespace PompeEssence
{
    partial class Delivery
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.deliveryText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deliveryText
            // 
            this.deliveryText.BackColor = System.Drawing.Color.Black;
            this.deliveryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryText.ForeColor = System.Drawing.Color.White;
            this.deliveryText.Location = new System.Drawing.Point(0, 0);
            this.deliveryText.Name = "deliveryText";
            this.deliveryText.Size = new System.Drawing.Size(480, 150);
            this.deliveryText.TabIndex = 5;
            this.deliveryText.Text = "DEBIT EN COURS";
            this.deliveryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deliveryText);
            this.Name = "Delivery";
            this.Size = new System.Drawing.Size(480, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deliveryText;
    }
}
