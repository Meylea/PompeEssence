
namespace PompeEssence
{
    partial class Actions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertCart = new System.Windows.Forms.Button();
            this.takeNozzle = new System.Windows.Forms.Button();
            this.removeCB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertCart
            // 
            this.insertCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCart.Location = new System.Drawing.Point(12, 41);
            this.insertCart.Name = "insertCart";
            this.insertCart.Size = new System.Drawing.Size(260, 32);
            this.insertCart.TabIndex = 0;
            this.insertCart.Text = "Insérer la carte";
            this.insertCart.UseVisualStyleBackColor = true;
            this.insertCart.Click += new System.EventHandler(this.button_Click);
            // 
            // takeNozzle
            // 
            this.takeNozzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeNozzle.Location = new System.Drawing.Point(12, 117);
            this.takeNozzle.Name = "takeNozzle";
            this.takeNozzle.Size = new System.Drawing.Size(260, 32);
            this.takeNozzle.TabIndex = 1;
            this.takeNozzle.Text = "Prendre le pistolet";
            this.takeNozzle.UseVisualStyleBackColor = true;
            this.takeNozzle.Click += new System.EventHandler(this.button_Click);
            // 
            // removeCB
            // 
            this.removeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCB.Location = new System.Drawing.Point(12, 79);
            this.removeCB.Name = "removeCB";
            this.removeCB.Size = new System.Drawing.Size(260, 32);
            this.removeCB.TabIndex = 2;
            this.removeCB.Text = "Retirer la carte";
            this.removeCB.UseVisualStyleBackColor = true;
            this.removeCB.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remettre le pistolet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeCB);
            this.Controls.Add(this.takeNozzle);
            this.Controls.Add(this.insertCart);
            this.Name = "Actions";
            this.Text = "Actions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertCart;
        private System.Windows.Forms.Button takeNozzle;
        private System.Windows.Forms.Button removeCB;
        private System.Windows.Forms.Button button1;
    }
}