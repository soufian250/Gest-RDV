namespace Gest_RDV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherRDVParDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesRDVDunPatienrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metreÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMedecinToolStripMenuItem,
            this.gestionDesPatientToolStripMenuItem,
            this.gestionDesRDVToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // gestionDesMedecinToolStripMenuItem
            // 
            this.gestionDesMedecinToolStripMenuItem.Name = "gestionDesMedecinToolStripMenuItem";
            this.gestionDesMedecinToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesMedecinToolStripMenuItem.Text = "Gestion des Medecins";
            this.gestionDesMedecinToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMedecinToolStripMenuItem_Click);
            // 
            // gestionDesPatientToolStripMenuItem
            // 
            this.gestionDesPatientToolStripMenuItem.Name = "gestionDesPatientToolStripMenuItem";
            this.gestionDesPatientToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesPatientToolStripMenuItem.Text = "Gestion des Patients";
            this.gestionDesPatientToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPatientToolStripMenuItem_Click);
            // 
            // gestionDesRDVToolStripMenuItem
            // 
            this.gestionDesRDVToolStripMenuItem.Name = "gestionDesRDVToolStripMenuItem";
            this.gestionDesRDVToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesRDVToolStripMenuItem.Text = "Gestion des RDV";
            this.gestionDesRDVToolStripMenuItem.Click += new System.EventHandler(this.gestionDesRDVToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToutToolStripMenuItem,
            this.rechercherRDVParDateToolStripMenuItem,
            this.afficherLesRDVDunPatienrToolStripMenuItem,
            this.metreÀJourToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // afficherToutToolStripMenuItem
            // 
            this.afficherToutToolStripMenuItem.Name = "afficherToutToolStripMenuItem";
            this.afficherToutToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.afficherToutToolStripMenuItem.Text = "Afficher Tout";
            this.afficherToutToolStripMenuItem.Click += new System.EventHandler(this.afficherToutToolStripMenuItem_Click);
            // 
            // rechercherRDVParDateToolStripMenuItem
            // 
            this.rechercherRDVParDateToolStripMenuItem.Name = "rechercherRDVParDateToolStripMenuItem";
            this.rechercherRDVParDateToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.rechercherRDVParDateToolStripMenuItem.Text = "Rechercher RDV par date";
            this.rechercherRDVParDateToolStripMenuItem.Click += new System.EventHandler(this.rechercherRDVParDateToolStripMenuItem_Click);
            // 
            // afficherLesRDVDunPatienrToolStripMenuItem
            // 
            this.afficherLesRDVDunPatienrToolStripMenuItem.Name = "afficherLesRDVDunPatienrToolStripMenuItem";
            this.afficherLesRDVDunPatienrToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.afficherLesRDVDunPatienrToolStripMenuItem.Text = "Afficher les RDV d\'un patient";
            this.afficherLesRDVDunPatienrToolStripMenuItem.Click += new System.EventHandler(this.afficherLesRDVDunPatienrToolStripMenuItem_Click);
            // 
            // metreÀJourToolStripMenuItem
            // 
            this.metreÀJourToolStripMenuItem.Name = "metreÀJourToolStripMenuItem";
            this.metreÀJourToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.metreÀJourToolStripMenuItem.Text = "Metre à jour";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 434);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulaire Principale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherRDVParDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesRDVDunPatienrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metreÀJourToolStripMenuItem;
    }
}

