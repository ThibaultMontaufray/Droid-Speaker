﻿namespace Droid_Speaker
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
            this.recoTextLabel = new System.Windows.Forms.Label();
            this.afficheLabel = new System.Windows.Forms.Label();
            this.devineLabel = new System.Windows.Forms.Label();
            this.recoText = new System.Windows.Forms.Label();
            this.affiche = new System.Windows.Forms.Label();
            this.devine = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.confidenceText = new System.Windows.Forms.Label();
            this.confidenceTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recoTextLabel
            // 
            this.recoTextLabel.AutoSize = true;
            this.recoTextLabel.Location = new System.Drawing.Point(12, 32);
            this.recoTextLabel.Name = "recoTextLabel";
            this.recoTextLabel.Size = new System.Drawing.Size(85, 13);
            this.recoTextLabel.TabIndex = 3;
            this.recoTextLabel.Text = "Texte reconnu : ";
            // 
            // afficheLabel
            // 
            this.afficheLabel.AutoSize = true;
            this.afficheLabel.Location = new System.Drawing.Point(12, 100);
            this.afficheLabel.Name = "afficheLabel";
            this.afficheLabel.Size = new System.Drawing.Size(123, 13);
            this.afficheLabel.TabIndex = 5;
            this.afficheLabel.Text = "Vous souhaitez afficher :";
            // 
            // devineLabel
            // 
            this.devineLabel.AutoSize = true;
            this.devineLabel.Location = new System.Drawing.Point(12, 123);
            this.devineLabel.Name = "devineLabel";
            this.devineLabel.Size = new System.Drawing.Size(71, 13);
            this.devineLabel.TabIndex = 6;
            this.devineLabel.Text = "Mots deviné :";
            // 
            // recoText
            // 
            this.recoText.AutoSize = true;
            this.recoText.Location = new System.Drawing.Point(103, 32);
            this.recoText.Name = "recoText";
            this.recoText.Size = new System.Drawing.Size(27, 13);
            this.recoText.TabIndex = 7;
            this.recoText.Text = "vide";
            // 
            // affiche
            // 
            this.affiche.AutoSize = true;
            this.affiche.Location = new System.Drawing.Point(141, 100);
            this.affiche.Name = "affiche";
            this.affiche.Size = new System.Drawing.Size(27, 13);
            this.affiche.TabIndex = 8;
            this.affiche.Text = "vide";
            // 
            // devine
            // 
            this.devine.AutoSize = true;
            this.devine.Location = new System.Drawing.Point(89, 123);
            this.devine.Name = "devine";
            this.devine.Size = new System.Drawing.Size(27, 13);
            this.devine.TabIndex = 9;
            this.devine.Text = "vide";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(12, 77);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(66, 13);
            this.commandLabel.TabIndex = 12;
            this.commandLabel.Text = "Commande :";
            // 
            // commandText
            // 
            this.commandText.AutoSize = true;
            this.commandText.Location = new System.Drawing.Point(84, 77);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(27, 13);
            this.commandText.TabIndex = 13;
            this.commandText.Text = "vide";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(12, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(309, 13);
            this.helpLabel.TabIndex = 14;
            this.helpLabel.Text = "Pressez la touche espace pour commencer la reconnaissance...";
            // 
            // confidenceText
            // 
            this.confidenceText.AutoSize = true;
            this.confidenceText.Location = new System.Drawing.Point(89, 54);
            this.confidenceText.Name = "confidenceText";
            this.confidenceText.Size = new System.Drawing.Size(24, 13);
            this.confidenceText.TabIndex = 16;
            this.confidenceText.Text = "0 %";
            // 
            // confidenceTextLabel
            // 
            this.confidenceTextLabel.AutoSize = true;
            this.confidenceTextLabel.Location = new System.Drawing.Point(12, 54);
            this.confidenceTextLabel.Name = "confidenceTextLabel";
            this.confidenceTextLabel.Size = new System.Drawing.Size(64, 13);
            this.confidenceTextLabel.TabIndex = 15;
            this.confidenceTextLabel.Text = "Confiance : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 153);
            this.Controls.Add(this.confidenceText);
            this.Controls.Add(this.confidenceTextLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.devine);
            this.Controls.Add(this.affiche);
            this.Controls.Add(this.recoText);
            this.Controls.Add(this.devineLabel);
            this.Controls.Add(this.afficheLabel);
            this.Controls.Add(this.recoTextLabel);
            this.Name = "Form1";
            this.Text = "Démonstrateur de reconnaissance vocale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label recoTextLabel;
        public System.Windows.Forms.Label afficheLabel;
        public System.Windows.Forms.Label devineLabel;
        public System.Windows.Forms.Label recoText;
        public System.Windows.Forms.Label affiche;
        public System.Windows.Forms.Label devine;
        public System.Windows.Forms.Label commandLabel;
        public System.Windows.Forms.Label commandText;
        public System.Windows.Forms.Label helpLabel;
        public System.Windows.Forms.Label confidenceText;
        public System.Windows.Forms.Label confidenceTextLabel;
    }
}