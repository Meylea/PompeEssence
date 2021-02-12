
namespace PompeEssence
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeCB1 = new PompeEssence.RemoveCB();
            this.takeNozzle1 = new PompeEssence.TakeNozzle();
            this.wait1 = new PompeEssence.Wait();
            this.goodCode1 = new PompeEssence.GoodCode();
            this.code1 = new PompeEssence.Code();
            this.fuelSelection1 = new PompeEssence.FuelSelection();
            this.home1 = new PompeEssence.Home();
            this.delivery1 = new PompeEssence.Delivery();
            this.SuspendLayout();
            // 
            // removeCB1
            // 
            this.removeCB1.Location = new System.Drawing.Point(1, 0);
            this.removeCB1.Name = "removeCB1";
            this.removeCB1.Size = new System.Drawing.Size(480, 660);
            this.removeCB1.TabIndex = 6;
            this.removeCB1.Visible = false;
            // 
            // takeNozzle1
            // 
            this.takeNozzle1.Location = new System.Drawing.Point(1, 0);
            this.takeNozzle1.Name = "takeNozzle1";
            this.takeNozzle1.Size = new System.Drawing.Size(480, 660);
            this.takeNozzle1.TabIndex = 5;
            this.takeNozzle1.Visible = false;
            // 
            // wait1
            // 
            this.wait1.Location = new System.Drawing.Point(1, 0);
            this.wait1.Name = "wait1";
            this.wait1.Size = new System.Drawing.Size(480, 660);
            this.wait1.TabIndex = 4;
            this.wait1.Visible = false;
            // 
            // goodCode1
            // 
            this.goodCode1.Location = new System.Drawing.Point(1, 0);
            this.goodCode1.Name = "goodCode1";
            this.goodCode1.Size = new System.Drawing.Size(480, 660);
            this.goodCode1.TabIndex = 3;
            this.goodCode1.Visible = false;
            // 
            // code1
            // 
            this.code1.Location = new System.Drawing.Point(1, 0);
            this.code1.Name = "code1";
            this.code1.Size = new System.Drawing.Size(480, 660);
            this.code1.TabIndex = 2;
            this.code1.Visible = false;
            // 
            // fuelSelection1
            // 
            this.fuelSelection1.Location = new System.Drawing.Point(1, 0);
            this.fuelSelection1.Name = "fuelSelection1";
            this.fuelSelection1.Size = new System.Drawing.Size(480, 660);
            this.fuelSelection1.TabIndex = 1;
            this.fuelSelection1.Visible = false;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(1, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(480, 660);
            this.home1.TabIndex = 0;
            // 
            // delivery1
            // 
            this.delivery1.Location = new System.Drawing.Point(1, 0);
            this.delivery1.Name = "delivery1";
            this.delivery1.Size = new System.Drawing.Size(480, 660);
            this.delivery1.TabIndex = 7;
            this.delivery1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.delivery1);
            this.Controls.Add(this.removeCB1);
            this.Controls.Add(this.takeNozzle1);
            this.Controls.Add(this.wait1);
            this.Controls.Add(this.goodCode1);
            this.Controls.Add(this.code1);
            this.Controls.Add(this.fuelSelection1);
            this.Controls.Add(this.home1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Home home1;
        private FuelSelection fuelSelection1;
        private Code code1;
        private GoodCode goodCode1;
        private Wait wait1;
        private TakeNozzle takeNozzle1;
        private RemoveCB removeCB1;
        private Delivery delivery1;
    }
}

