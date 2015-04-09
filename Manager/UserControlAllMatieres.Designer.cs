namespace Manager
{
    partial class UserControlAllMatieres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanelEditMatiere = new MetroFramework.Controls.MetroPanel();
            this.ButtonSelectProf = new MetroFramework.Controls.MetroButton();
            this.PanelEditMatiere = new MetroFramework.Controls.MetroPanel();
            this.ButtonAnnulerMatiere = new MetroFramework.Controls.MetroButton();
            this.ButtonSaveMatiere = new MetroFramework.Controls.MetroButton();
            this.TextBoxCoefficient = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxResponsable = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDesignationMatiere = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GridMatieres = new MetroFramework.Controls.MetroGrid();
            this.ButtonAddMatiere = new MetroFramework.Controls.MetroButton();
            this.ButtonAlterMatiere = new MetroFramework.Controls.MetroButton();
            this.ButtonDleteMatiere = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelEditMatiere.SuspendLayout();
            this.PanelEditMatiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatieres)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelEditMatiere
            // 
            this.metroPanelEditMatiere.Controls.Add(this.ButtonSelectProf);
            this.metroPanelEditMatiere.Controls.Add(this.PanelEditMatiere);
            this.metroPanelEditMatiere.Controls.Add(this.TextBoxCoefficient);
            this.metroPanelEditMatiere.Controls.Add(this.ComboBoxResponsable);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel4);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel2);
            this.metroPanelEditMatiere.Controls.Add(this.TextBoxDesignationMatiere);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel1);
            this.metroPanelEditMatiere.HorizontalScrollbarBarColor = true;
            this.metroPanelEditMatiere.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEditMatiere.HorizontalScrollbarSize = 10;
            this.metroPanelEditMatiere.Location = new System.Drawing.Point(12, 69);
            this.metroPanelEditMatiere.Name = "metroPanelEditMatiere";
            this.metroPanelEditMatiere.Size = new System.Drawing.Size(294, 224);
            this.metroPanelEditMatiere.TabIndex = 0;
            this.metroPanelEditMatiere.VerticalScrollbarBarColor = true;
            this.metroPanelEditMatiere.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEditMatiere.VerticalScrollbarSize = 10;
            // 
            // ButtonSelectProf
            // 
            this.ButtonSelectProf.AccessibleDescription = "Ajouter d\'autre professeur";
            this.ButtonSelectProf.Location = new System.Drawing.Point(264, 106);
            this.ButtonSelectProf.Name = "ButtonSelectProf";
            this.ButtonSelectProf.Size = new System.Drawing.Size(27, 29);
            this.ButtonSelectProf.TabIndex = 13;
            this.ButtonSelectProf.Text = "...";
            this.ButtonSelectProf.UseSelectable = true;
            // 
            // PanelEditMatiere
            // 
            this.PanelEditMatiere.Controls.Add(this.ButtonAnnulerMatiere);
            this.PanelEditMatiere.Controls.Add(this.ButtonSaveMatiere);
            this.PanelEditMatiere.HorizontalScrollbarBarColor = true;
            this.PanelEditMatiere.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelEditMatiere.HorizontalScrollbarSize = 10;
            this.PanelEditMatiere.Location = new System.Drawing.Point(8, 151);
            this.PanelEditMatiere.Name = "PanelEditMatiere";
            this.PanelEditMatiere.Size = new System.Drawing.Size(253, 36);
            this.PanelEditMatiere.TabIndex = 12;
            this.PanelEditMatiere.VerticalScrollbarBarColor = true;
            this.PanelEditMatiere.VerticalScrollbarHighlightOnWheel = false;
            this.PanelEditMatiere.VerticalScrollbarSize = 10;
            // 
            // ButtonAnnulerMatiere
            // 
            this.ButtonAnnulerMatiere.Location = new System.Drawing.Point(146, 7);
            this.ButtonAnnulerMatiere.Name = "ButtonAnnulerMatiere";
            this.ButtonAnnulerMatiere.Size = new System.Drawing.Size(86, 23);
            this.ButtonAnnulerMatiere.TabIndex = 11;
            this.ButtonAnnulerMatiere.Text = "Annuler";
            this.ButtonAnnulerMatiere.UseSelectable = true;
            // 
            // ButtonSaveMatiere
            // 
            this.ButtonSaveMatiere.Location = new System.Drawing.Point(19, 7);
            this.ButtonSaveMatiere.Name = "ButtonSaveMatiere";
            this.ButtonSaveMatiere.Size = new System.Drawing.Size(86, 23);
            this.ButtonSaveMatiere.TabIndex = 10;
            this.ButtonSaveMatiere.Text = "Sauvegarder";
            this.ButtonSaveMatiere.UseSelectable = true;
            // 
            // TextBoxCoefficient
            // 
            this.TextBoxCoefficient.Lines = new string[0];
            this.TextBoxCoefficient.Location = new System.Drawing.Point(96, 61);
            this.TextBoxCoefficient.MaxLength = 32767;
            this.TextBoxCoefficient.Name = "TextBoxCoefficient";
            this.TextBoxCoefficient.PasswordChar = '\0';
            this.TextBoxCoefficient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCoefficient.SelectedText = "";
            this.TextBoxCoefficient.Size = new System.Drawing.Size(112, 23);
            this.TextBoxCoefficient.TabIndex = 9;
            this.TextBoxCoefficient.UseSelectable = true;
            // 
            // ComboBoxResponsable
            // 
            this.ComboBoxResponsable.AllowDrop = true;
            this.ComboBoxResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxResponsable.FormattingEnabled = true;
            this.ComboBoxResponsable.ItemHeight = 23;
            this.ComboBoxResponsable.Location = new System.Drawing.Point(96, 106);
            this.ComboBoxResponsable.MaxDropDownItems = 15;
            this.ComboBoxResponsable.Name = "ComboBoxResponsable";
            this.ComboBoxResponsable.Size = new System.Drawing.Size(162, 29);
            this.ComboBoxResponsable.Sorted = true;
            this.ComboBoxResponsable.TabIndex = 8;
            this.ComboBoxResponsable.UseCustomBackColor = true;
            this.ComboBoxResponsable.UseCustomForeColor = true;
            this.ComboBoxResponsable.UseSelectable = true;
            this.ComboBoxResponsable.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Responsable : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Coefficient : ";
            // 
            // TextBoxDesignationMatiere
            // 
            this.TextBoxDesignationMatiere.Lines = new string[0];
            this.TextBoxDesignationMatiere.Location = new System.Drawing.Point(96, 16);
            this.TextBoxDesignationMatiere.MaxLength = 32767;
            this.TextBoxDesignationMatiere.Name = "TextBoxDesignationMatiere";
            this.TextBoxDesignationMatiere.PasswordChar = '\0';
            this.TextBoxDesignationMatiere.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDesignationMatiere.SelectedText = "";
            this.TextBoxDesignationMatiere.Size = new System.Drawing.Size(162, 23);
            this.TextBoxDesignationMatiere.TabIndex = 3;
            this.TextBoxDesignationMatiere.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Désignation : ";
            // 
            // GridMatieres
            // 
            this.GridMatieres.AllowUserToOrderColumns = true;
            this.GridMatieres.AllowUserToResizeRows = false;
            this.GridMatieres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMatieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMatieres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridMatieres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMatieres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMatieres.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridMatieres.EnableHeadersVisualStyles = false;
            this.GridMatieres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridMatieres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMatieres.Location = new System.Drawing.Point(405, 42);
            this.GridMatieres.Name = "GridMatieres";
            this.GridMatieres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMatieres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridMatieres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridMatieres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMatieres.Size = new System.Drawing.Size(224, 344);
            this.GridMatieres.TabIndex = 1;
            // 
            // ButtonAddMatiere
            // 
            this.ButtonAddMatiere.Location = new System.Drawing.Point(324, 104);
            this.ButtonAddMatiere.Name = "ButtonAddMatiere";
            this.ButtonAddMatiere.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddMatiere.TabIndex = 2;
            this.ButtonAddMatiere.Text = "Ajouter";
            this.ButtonAddMatiere.UseSelectable = true;
            // 
            // ButtonAlterMatiere
            // 
            this.ButtonAlterMatiere.Location = new System.Drawing.Point(324, 137);
            this.ButtonAlterMatiere.Name = "ButtonAlterMatiere";
            this.ButtonAlterMatiere.Size = new System.Drawing.Size(75, 23);
            this.ButtonAlterMatiere.TabIndex = 3;
            this.ButtonAlterMatiere.Text = "Modifier";
            this.ButtonAlterMatiere.UseSelectable = true;
            // 
            // ButtonDleteMatiere
            // 
            this.ButtonDleteMatiere.Location = new System.Drawing.Point(324, 170);
            this.ButtonDleteMatiere.Name = "ButtonDleteMatiere";
            this.ButtonDleteMatiere.Size = new System.Drawing.Size(75, 23);
            this.ButtonDleteMatiere.TabIndex = 4;
            this.ButtonDleteMatiere.Text = "Supprimer";
            this.ButtonDleteMatiere.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Matières";
            // 
            // UserControlAllMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ButtonDleteMatiere);
            this.Controls.Add(this.ButtonAlterMatiere);
            this.Controls.Add(this.ButtonAddMatiere);
            this.Controls.Add(this.GridMatieres);
            this.Controls.Add(this.metroPanelEditMatiere);
            this.Name = "UserControlAllMatieres";
            this.Size = new System.Drawing.Size(644, 399);
            this.metroPanelEditMatiere.ResumeLayout(false);
            this.metroPanelEditMatiere.PerformLayout();
            this.PanelEditMatiere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMatieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelEditMatiere;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxDesignationMatiere;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ComboBoxResponsable;
        private MetroFramework.Controls.MetroTextBox TextBoxCoefficient;
        private MetroFramework.Controls.MetroButton ButtonAnnulerMatiere;
        private MetroFramework.Controls.MetroButton ButtonSaveMatiere;
        private MetroFramework.Controls.MetroPanel PanelEditMatiere;
        private MetroFramework.Controls.MetroGrid GridMatieres;
        private MetroFramework.Controls.MetroButton ButtonAddMatiere;
        private MetroFramework.Controls.MetroButton ButtonAlterMatiere;
        private MetroFramework.Controls.MetroButton ButtonDleteMatiere;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton ButtonSelectProf;
    }
}
