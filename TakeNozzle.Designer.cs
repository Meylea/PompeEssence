
namespace PompeEssence
{
    partial class TakeNozzle
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
            this.takeNozzleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takeNozzleText
            // 
            this.takeNozzleText.BackColor = System.Drawing.Color.Black;
            this.takeNozzleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeNozzleText.ForeColor = System.Drawing.Color.White;
            this.takeNozzleText.Location = new System.Drawing.Point(0, 0);
            this.takeNozzleText.Name = "takeNozzleText";
            this.takeNozzleText.Size = new System.Drawing.Size(480, 150);
            this.takeNozzleText.TabIndex = 5;
            this.takeNozzleText.Text = "VEUILLEZ DECROCHER\r\nLE PISTOLET DE\r\n";
            this.takeNozzleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeNozzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.takeNozzleText);
            this.Name = "TakeNozzle";
            this.Size = new System.Drawing.Size(480, 660);
            this.VisibleChanged += new System.EventHandler(this.TakeNozzle_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label takeNozzleText;
    }
}
