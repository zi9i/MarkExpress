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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanelEditMatiere = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDesignationMatiere = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxModule = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxResponsable = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxCoefficient = new MetroFramework.Controls.MetroTextBox();
            this.ButtonSaveMatiere = new MetroFramework.Controls.MetroButton();
            this.ButtonAnnulerMatiere = new MetroFramework.Controls.MetroButton();
            this.PanelEditMatiere = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanelEditMatiere.SuspendLayout();
            this.PanelEditMatiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelEditMatiere
            // 
            this.metroPanelEditMatiere.Controls.Add(this.PanelEditMatiere);
            this.metroPanelEditMatiere.Controls.Add(this.TextBoxCoefficient);
            this.metroPanelEditMatiere.Controls.Add(this.ComboBoxResponsable);
            this.metroPanelEditMatiere.Controls.Add(this.ComboBoxModule);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel4);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel3);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel2);
            this.metroPanelEditMatiere.Controls.Add(this.TextBoxDesignationMatiere);
            this.metroPanelEditMatiere.Controls.Add(this.metroLabel1);
            this.metroPanelEditMatiere.HorizontalScrollbarBarColor = true;
            this.metroPanelEditMatiere.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEditMatiere.HorizontalScrollbarSize = 10;
            this.metroPanelEditMatiere.Location = new System.Drawing.Point(12, 69);
            this.metroPanelEditMatiere.Name = "metroPanelEditMatiere";
            this.metroPanelEditMatiere.Size = new System.Drawing.Size(294, 299);
            this.metroPanelEditMatiere.TabIndex = 0;
            this.metroPanelEditMatiere.VerticalScrollbarBarColor = true;
            this.metroPanelEditMatiere.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEditMatiere.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Désignation : ";
            // 
            // TextBoxDesignationMatiere
            // 
            this.TextBoxDesignationMatiere.Lines = new string[0];
            this.TextBoxDesignationMatiere.Location = new System.Drawing.Point(120, 38);
            this.TextBoxDesignationMatiere.MaxLength = 32767;
            this.TextBoxDesignationMatiere.Name = "TextBoxDesignationMatiere";
            this.TextBoxDesignationMatiere.PasswordChar = '\0';
            this.TextBoxDesignationMatiere.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDesignationMatiere.SelectedText = "";
            this.TextBoxDesignationMatiere.Size = new System.Drawing.Size(162, 23);
            this.TextBoxDesignationMatiere.TabIndex = 3;
            this.TextBoxDesignationMatiere.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Coefficient : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Module : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Responsable : ";
            // 
            // ComboBoxModule
            // 
            this.ComboBoxModule.AllowDrop = true;
            this.ComboBoxModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxModule.FormattingEnabled = true;
            this.ComboBoxModule.ItemHeight = 23;
            this.ComboBoxModule.Location = new System.Drawing.Point(120, 128);
            this.ComboBoxModule.Name = "ComboBoxModule";
            this.ComboBoxModule.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxModule.Sorted = true;
            this.ComboBoxModule.TabIndex = 7;
            this.ComboBoxModule.UseSelectable = true;
            // 
            // ComboBoxResponsable
            // 
            this.ComboBoxResponsable.FormattingEnabled = true;
            this.ComboBoxResponsable.ItemHeight = 23;
            this.ComboBoxResponsable.Location = new System.Drawing.Point(120, 178);
            this.ComboBoxResponsable.Name = "ComboBoxResponsable";
            this.ComboBoxResponsable.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxResponsable.TabIndex = 8;
            this.ComboBoxResponsable.UseSelectable = true;
            // 
            // TextBoxCoefficient
            // 
            this.TextBoxCoefficient.Lines = new string[0];
            this.TextBoxCoefficient.Location = new System.Drawing.Point(120, 88);
            this.TextBoxCoefficient.MaxLength = 32767;
            this.TextBoxCoefficient.Name = "TextBoxCoefficient";
            this.TextBoxCoefficient.PasswordChar = '\0';
            this.TextBoxCoefficient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCoefficient.SelectedText = "";
            this.TextBoxCoefficient.Size = new System.Drawing.Size(112, 23);
            this.TextBoxCoefficient.TabIndex = 9;
            this.TextBoxCoefficient.UseSelectable = true;
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
            // ButtonAnnulerMatiere
            // 
            this.ButtonAnnulerMatiere.Location = new System.Drawing.Point(146, 7);
            this.ButtonAnnulerMatiere.Name = "ButtonAnnulerMatiere";
            this.ButtonAnnulerMatiere.Size = new System.Drawing.Size(86, 23);
            this.ButtonAnnulerMatiere.TabIndex = 11;
            this.ButtonAnnulerMatiere.Text = "Annuler";
            this.ButtonAnnulerMatiere.UseSelectable = true;
            // 
            // PanelEditMatiere
            // 
            this.PanelEditMatiere.Controls.Add(this.ButtonAnnulerMatiere);
            this.PanelEditMatiere.Controls.Add(this.ButtonSaveMatiere);
            this.PanelEditMatiere.HorizontalScrollbarBarColor = true;
            this.PanelEditMatiere.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelEditMatiere.HorizontalScrollbarSize = 10;
            this.PanelEditMatiere.Location = new System.Drawing.Point(20, 244);
            this.PanelEditMatiere.Name = "PanelEditMatiere";
            this.PanelEditMatiere.Size = new System.Drawing.Size(253, 36);
            this.PanelEditMatiere.TabIndex = 12;
            this.PanelEditMatiere.VerticalScrollbarBarColor = true;
            this.PanelEditMatiere.VerticalScrollbarHighlightOnWheel = false;
            this.PanelEditMatiere.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(346, 112);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 1;
            // 
            // UserControlAllMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanelEditMatiere);
            this.Name = "UserControlAllMatieres";
            this.Size = new System.Drawing.Size(722, 399);
            this.metroPanelEditMatiere.ResumeLayout(false);
            this.metroPanelEditMatiere.PerformLayout();
            this.PanelEditMatiere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelEditMatiere;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxDesignationMatiere;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ComboBoxResponsable;
        private MetroFramework.Controls.MetroComboBox ComboBoxModule;
        private MetroFramework.Controls.MetroTextBox TextBoxCoefficient;
        private MetroFramework.Controls.MetroButton ButtonAnnulerMatiere;
        private MetroFramework.Controls.MetroButton ButtonSaveMatiere;
        private MetroFramework.Controls.MetroPanel PanelEditMatiere;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}
