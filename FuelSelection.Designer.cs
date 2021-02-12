
namespace PompeEssence
{
    partial class FuelSelection
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
            this.fuelSelectionText = new System.Windows.Forms.Label();
            this.SP98 = new System.Windows.Forms.Button();
            this.E10 = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Button();
            this.cancel = new PompeEssence.Cancel();
            this.SuspendLayout();
            // 
            // fuelSelectionText
            // 
            this.fuelSelectionText.BackColor = System.Drawing.Color.Black;
            this.fuelSelectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelSelectionText.ForeColor = System.Drawing.Color.White;
            this.fuelSelectionText.Location = new System.Drawing.Point(0, 0);
            this.fuelSelectionText.Name = "fuelSelectionText";
            this.fuelSelectionText.Size = new System.Drawing.Size(480, 150);
            this.fuelSelectionText.TabIndex = 3;
            this.fuelSelectionText.Text = "SELECTIONNEZ\r\nVOTRE CARBURANT";
            this.fuelSelectionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SP98
            // 
            this.SP98.BackColor = System.Drawing.Color.Black;
            this.SP98.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP98.ForeColor = System.Drawing.Color.White;
            this.SP98.Location = new System.Drawing.Point(6, 169);
            this.SP98.Name = "SP98";
            this.SP98.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SP98.Size = new System.Drawing.Size(350, 100);
            this.SP98.TabIndex = 4;
            this.SP98.Text = "SP98\r\n    1,329€/L";
            this.SP98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SP98.UseVisualStyleBackColor = false;
            this.SP98.Click += new System.EventHandler(this.Button_Click);
            // 
            // E10
            // 
            this.E10.BackColor = System.Drawing.Color.Black;
            this.E10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E10.ForeColor = System.Drawing.Color.White;
            this.E10.Location = new System.Drawing.Point(6, 275);
            this.E10.Name = "E10";
            this.E10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.E10.Size = new System.Drawing.Size(350, 100);
            this.E10.TabIndex = 5;
            this.E10.Text = "E10\r\n    1,279€/L";
            this.E10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.E10.UseVisualStyleBackColor = false;
            this.E10.Click += new System.EventHandler(this.Button_Click);
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.Black;
            this.GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ForeColor = System.Drawing.Color.White;
            this.GO.Location = new System.Drawing.Point(6, 381);
            this.GO.Name = "GO";
            this.GO.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.GO.Size = new System.Drawing.Size(350, 100);
            this.GO.TabIndex = 6;
            this.GO.Text = "GO\r\n    1,329€/L";
            this.GO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GO.UseVisualStyleBackColor = false;
            this.GO.Click += new System.EventHandler(this.Button_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(384, 169);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 75);
            this.cancel.TabIndex = 7;
            this.cancel.Click += new System.EventHandler(this.Button_Click);
            // 
            // FuelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.E10);
            this.Controls.Add(this.SP98);
            this.Controls.Add(this.fuelSelectionText);
            this.Name = "FuelSelection";
            this.Size = new System.Drawing.Size(480, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fuelSelectionText;
        private System.Windows.Forms.Button SP98;
        private System.Windows.Forms.Button E10;
        private System.Windows.Forms.Button GO;
        private Cancel cancel;
    }
}
