
namespace PompeEssence
{
    partial class Home
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
            this.bienvenue = new System.Windows.Forms.Label();
            this.insertCartText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bienvenue
            // 
            this.bienvenue.BackColor = System.Drawing.Color.Black;
            this.bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenue.ForeColor = System.Drawing.Color.White;
            this.bienvenue.Location = new System.Drawing.Point(0, 0);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(480, 50);
            this.bienvenue.TabIndex = 1;
            this.bienvenue.Text = "BIENVENUE";
            this.bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertCartText
            // 
            this.insertCartText.BackColor = System.Drawing.Color.Black;
            this.insertCartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCartText.ForeColor = System.Drawing.Color.White;
            this.insertCartText.Location = new System.Drawing.Point(0, 160);
            this.insertCartText.Name = "insertCartText";
            this.insertCartText.Size = new System.Drawing.Size(480, 150);
            this.insertCartText.TabIndex = 2;
            this.insertCartText.Text = "EN SERVICE\r\nINSEREZ VOTRE CARTE\r\nJUSQU\'A LA BUTEE";
            this.insertCartText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insertCartText);
            this.Controls.Add(this.bienvenue);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(480, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.Label insertCartText;
    }
}
