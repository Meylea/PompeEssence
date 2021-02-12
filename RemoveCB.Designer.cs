
namespace PompeEssence
{
    partial class RemoveCB
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
            this.cancel1 = new PompeEssence.Cancel();
            this.infos = new System.Windows.Forms.Label();
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
            this.goodCodeText.TabIndex = 5;
            this.goodCodeText.Text = "RETIREZ VOTRE CARTE";
            this.goodCodeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(387, 163);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(75, 75);
            this.cancel1.TabIndex = 6;
            // 
            // infos
            // 
            this.infos.BackColor = System.Drawing.Color.Black;
            this.infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos.ForeColor = System.Drawing.Color.White;
            this.infos.Location = new System.Drawing.Point(-6, 150);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(366, 114);
            this.infos.TabIndex = 7;
            this.infos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infos);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.goodCodeText);
            this.Name = "RemoveCB";
            this.Size = new System.Drawing.Size(480, 660);
            this.VisibleChanged += new System.EventHandler(this.RemoveCB_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label goodCodeText;
        private Cancel cancel1;
        private System.Windows.Forms.Label infos;
    }
}
