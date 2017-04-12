namespace Adressbuch
{
    partial class formViewContact
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formViewContact));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonApplyFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.auswahlLand = new System.Windows.Forms.ComboBox();
            this.comboBoxAnrede = new System.Windows.Forms.ComboBox();
            this.labelHausnummer = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelLand = new System.Windows.Forms.Label();
            this.labelPostleitzahl = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.labelStraße = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelAnrede = new System.Windows.Forms.Label();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.textBoxPostleitzahl = new System.Windows.Forms.TextBox();
            this.textBoxHausnummer = new System.Windows.Forms.TextBox();
            this.textBoxStraße = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobilnummer = new System.Windows.Forms.Label();
            this.labelTelefonnummer = new System.Windows.Forms.Label();
            this.textBoxMobilnummer = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.textBoxTelefonnummer = new System.Windows.Forms.TextBox();
            this.bindingSourcePerson = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonApplyFilter,
            this.toolStripButtonRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonApplyFilter
            // 
            this.toolStripButtonApplyFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonApplyFilter.Image")));
            this.toolStripButtonApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApplyFilter.Name = "toolStripButtonApplyFilter";
            this.toolStripButtonApplyFilter.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonApplyFilter.Text = "Filter Anwenden";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRefresh.Text = "Aktualisieren";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(12, 409);
            this.dataGridViewContacts.MultiSelect = false;
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.ReadOnly = true;
            this.dataGridViewContacts.RowTemplate.Height = 24;
            this.dataGridViewContacts.Size = new System.Drawing.Size(828, 234);
            this.dataGridViewContacts.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(732, 369);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 29);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Editieren";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(348, 164);
            this.textBoxTitel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(132, 22);
            this.textBoxTitel.TabIndex = 59;
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(262, 167);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(35, 17);
            this.labelTitel.TabIndex = 58;
            this.labelTitel.Text = "Titel";
            // 
            // auswahlLand
            // 
            this.auswahlLand.FormattingEnabled = true;
            this.auswahlLand.Location = new System.Drawing.Point(122, 363);
            this.auswahlLand.Margin = new System.Windows.Forms.Padding(4);
            this.auswahlLand.Name = "auswahlLand";
            this.auswahlLand.Size = new System.Drawing.Size(132, 24);
            this.auswahlLand.TabIndex = 57;
            // 
            // comboBoxAnrede
            // 
            this.comboBoxAnrede.FormattingEnabled = true;
            this.comboBoxAnrede.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.comboBoxAnrede.Location = new System.Drawing.Point(122, 164);
            this.comboBoxAnrede.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAnrede.Name = "comboBoxAnrede";
            this.comboBoxAnrede.Size = new System.Drawing.Size(132, 24);
            this.comboBoxAnrede.TabIndex = 56;
            // 
            // labelHausnummer
            // 
            this.labelHausnummer.AutoSize = true;
            this.labelHausnummer.Location = new System.Drawing.Point(262, 267);
            this.labelHausnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHausnummer.Name = "labelHausnummer";
            this.labelHausnummer.Size = new System.Drawing.Size(61, 17);
            this.labelHausnummer.TabIndex = 55;
            this.labelHausnummer.Text = "Nummer";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(22, 217);
            this.labelVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(65, 17);
            this.labelVorname.TabIndex = 54;
            this.labelVorname.Text = "Vorname";
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(22, 365);
            this.labelLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(40, 17);
            this.labelLand.TabIndex = 53;
            this.labelLand.Text = "Land";
            // 
            // labelPostleitzahl
            // 
            this.labelPostleitzahl.AutoSize = true;
            this.labelPostleitzahl.Location = new System.Drawing.Point(22, 316);
            this.labelPostleitzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostleitzahl.Name = "labelPostleitzahl";
            this.labelPostleitzahl.Size = new System.Drawing.Size(80, 17);
            this.labelPostleitzahl.TabIndex = 52;
            this.labelPostleitzahl.Text = "Postleitzahl";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(262, 316);
            this.labelOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(28, 17);
            this.labelOrt.TabIndex = 51;
            this.labelOrt.Text = "Ort";
            // 
            // labelStraße
            // 
            this.labelStraße.AutoSize = true;
            this.labelStraße.Location = new System.Drawing.Point(22, 267);
            this.labelStraße.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStraße.Name = "labelStraße";
            this.labelStraße.Size = new System.Drawing.Size(51, 17);
            this.labelStraße.TabIndex = 50;
            this.labelStraße.Text = "Straße";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(262, 217);
            this.labelNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(76, 17);
            this.labelNachname.TabIndex = 49;
            this.labelNachname.Text = "Nachname";
            // 
            // labelAnrede
            // 
            this.labelAnrede.AutoSize = true;
            this.labelAnrede.Location = new System.Drawing.Point(22, 168);
            this.labelAnrede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnrede.Name = "labelAnrede";
            this.labelAnrede.Size = new System.Drawing.Size(54, 17);
            this.labelAnrede.TabIndex = 48;
            this.labelAnrede.Text = "Anrede";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(348, 313);
            this.textBoxOrt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(132, 22);
            this.textBoxOrt.TabIndex = 47;
            // 
            // textBoxPostleitzahl
            // 
            this.textBoxPostleitzahl.Location = new System.Drawing.Point(122, 313);
            this.textBoxPostleitzahl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostleitzahl.Name = "textBoxPostleitzahl";
            this.textBoxPostleitzahl.Size = new System.Drawing.Size(132, 22);
            this.textBoxPostleitzahl.TabIndex = 46;
            // 
            // textBoxHausnummer
            // 
            this.textBoxHausnummer.Location = new System.Drawing.Point(348, 264);
            this.textBoxHausnummer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHausnummer.Name = "textBoxHausnummer";
            this.textBoxHausnummer.Size = new System.Drawing.Size(63, 22);
            this.textBoxHausnummer.TabIndex = 45;
            // 
            // textBoxStraße
            // 
            this.textBoxStraße.Location = new System.Drawing.Point(122, 264);
            this.textBoxStraße.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStraße.Name = "textBoxStraße";
            this.textBoxStraße.Size = new System.Drawing.Size(132, 22);
            this.textBoxStraße.TabIndex = 44;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(348, 214);
            this.textBoxNachname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(132, 22);
            this.textBoxNachname.TabIndex = 43;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(122, 214);
            this.textBoxVorname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(132, 22);
            this.textBoxVorname.TabIndex = 42;
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(514, 316);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(59, 17);
            this.labelWebsite.TabIndex = 67;
            this.labelWebsite.Text = "Website";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(514, 266);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 66;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelMobilnummer
            // 
            this.labelMobilnummer.AutoSize = true;
            this.labelMobilnummer.Location = new System.Drawing.Point(514, 216);
            this.labelMobilnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMobilnummer.Name = "labelMobilnummer";
            this.labelMobilnummer.Size = new System.Drawing.Size(98, 17);
            this.labelMobilnummer.TabIndex = 65;
            this.labelMobilnummer.Text = "Mobil Nummer";
            // 
            // labelTelefonnummer
            // 
            this.labelTelefonnummer.AutoSize = true;
            this.labelTelefonnummer.Location = new System.Drawing.Point(514, 167);
            this.labelTelefonnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefonnummer.Name = "labelTelefonnummer";
            this.labelTelefonnummer.Size = new System.Drawing.Size(89, 17);
            this.labelTelefonnummer.TabIndex = 64;
            this.labelTelefonnummer.Text = "Tel. Nummer";
            // 
            // textBoxMobilnummer
            // 
            this.textBoxMobilnummer.Location = new System.Drawing.Point(634, 212);
            this.textBoxMobilnummer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMobilnummer.Name = "textBoxMobilnummer";
            this.textBoxMobilnummer.Size = new System.Drawing.Size(187, 22);
            this.textBoxMobilnummer.TabIndex = 63;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(634, 262);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(187, 22);
            this.textBoxEmail.TabIndex = 62;
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(634, 312);
            this.textBoxWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(187, 22);
            this.textBoxWebsite.TabIndex = 61;
            // 
            // textBoxTelefonnummer
            // 
            this.textBoxTelefonnummer.Location = new System.Drawing.Point(634, 162);
            this.textBoxTelefonnummer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefonnummer.Name = "textBoxTelefonnummer";
            this.textBoxTelefonnummer.Size = new System.Drawing.Size(187, 22);
            this.textBoxTelefonnummer.TabIndex = 60;
            // 
            // formViewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 655);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelMobilnummer);
            this.Controls.Add(this.labelTelefonnummer);
            this.Controls.Add(this.textBoxMobilnummer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxWebsite);
            this.Controls.Add(this.textBoxTelefonnummer);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.auswahlLand);
            this.Controls.Add(this.comboBoxAnrede);
            this.Controls.Add(this.labelHausnummer);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.labelLand);
            this.Controls.Add(this.labelPostleitzahl);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.labelStraße);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.labelAnrede);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.textBoxPostleitzahl);
            this.Controls.Add(this.textBoxHausnummer);
            this.Controls.Add(this.textBoxStraße);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formViewContact";
            this.Text = "Adressbuch";
            this.Load += new System.EventHandler(this.formViewContact_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonApplyFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.ComboBox auswahlLand;
        private System.Windows.Forms.ComboBox comboBoxAnrede;
        private System.Windows.Forms.Label labelHausnummer;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.Label labelPostleitzahl;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Label labelStraße;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelAnrede;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.TextBox textBoxPostleitzahl;
        private System.Windows.Forms.TextBox textBoxHausnummer;
        private System.Windows.Forms.TextBox textBoxStraße;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobilnummer;
        private System.Windows.Forms.Label labelTelefonnummer;
        private System.Windows.Forms.TextBox textBoxMobilnummer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.TextBox textBoxTelefonnummer;
        private System.Windows.Forms.BindingSource bindingSourcePerson;
    }
}

