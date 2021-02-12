
namespace PompeEssence
{
    partial class GoodCode
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
            this.goodCodeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goodCodeText
            // 
            this.goodCodeText.BackColor = System.Drawing.Color.Black;
            this.goodCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodCodeText.ForeColor = System.Drawing.Color.White;
            this.goodCodeText.Location = new System.Drawing.Point(0, 0);
            this.goodCodeText.Name = "goodCodeText";
            this.goodCodeText.Size = new System.Drawing.Size(480, 150);
            this.goodCodeText.TabIndex = 4;
            this.goodCodeText.Text = "CODE BON";
            this.goodCodeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoodCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goodCodeText);
            this.Name = "GoodCode";
            this.Size = new System.Drawing.Size(480, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label goodCodeText;
    }
}
