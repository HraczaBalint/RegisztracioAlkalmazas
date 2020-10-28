namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzulDat = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.radioButtonNemF = new System.Windows.Forms.RadioButton();
            this.radioButtonNemN = new System.Windows.Forms.RadioButton();
            this.labelKedvHobbi = new System.Windows.Forms.Label();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.dateTimePickerSzulDat = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialogMentes = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBetoltes = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNev.Location = new System.Drawing.Point(12, 9);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(100, 50);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név:";
            this.labelNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSzulDat
            // 
            this.labelSzulDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzulDat.Location = new System.Drawing.Point(12, 59);
            this.labelSzulDat.Name = "labelSzulDat";
            this.labelSzulDat.Size = new System.Drawing.Size(180, 50);
            this.labelSzulDat.TabIndex = 1;
            this.labelSzulDat.Text = "Születési dátum:";
            this.labelSzulDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNem
            // 
            this.labelNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNem.Location = new System.Drawing.Point(12, 109);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(100, 50);
            this.labelNem.TabIndex = 2;
            this.labelNem.Text = "Nem:";
            this.labelNem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNev.Location = new System.Drawing.Point(202, 19);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(197, 32);
            this.textBoxNev.TabIndex = 3;
            // 
            // radioButtonNemF
            // 
            this.radioButtonNemF.AutoSize = true;
            this.radioButtonNemF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonNemF.Location = new System.Drawing.Point(202, 119);
            this.radioButtonNemF.Name = "radioButtonNemF";
            this.radioButtonNemF.Size = new System.Drawing.Size(43, 30);
            this.radioButtonNemF.TabIndex = 5;
            this.radioButtonNemF.Text = "F";
            this.radioButtonNemF.UseVisualStyleBackColor = true;
            // 
            // radioButtonNemN
            // 
            this.radioButtonNemN.AutoSize = true;
            this.radioButtonNemN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonNemN.Location = new System.Drawing.Point(306, 119);
            this.radioButtonNemN.Name = "radioButtonNemN";
            this.radioButtonNemN.Size = new System.Drawing.Size(46, 30);
            this.radioButtonNemN.TabIndex = 6;
            this.radioButtonNemN.TabStop = true;
            this.radioButtonNemN.Text = "N";
            this.radioButtonNemN.UseVisualStyleBackColor = true;
            // 
            // labelKedvHobbi
            // 
            this.labelKedvHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKedvHobbi.Location = new System.Drawing.Point(442, 9);
            this.labelKedvHobbi.Name = "labelKedvHobbi";
            this.labelKedvHobbi.Size = new System.Drawing.Size(180, 50);
            this.labelKedvHobbi.TabIndex = 7;
            this.labelKedvHobbi.Text = "Kedvenc hobbi:";
            this.labelKedvHobbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.ItemHeight = 25;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "Futás",
            "Úszás",
            "Kerékpározás"});
            this.listBoxHobbik.Location = new System.Drawing.Point(447, 69);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(175, 154);
            this.listBoxHobbik.TabIndex = 8;
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUjHobbi.Location = new System.Drawing.Point(329, 235);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(98, 50);
            this.labelUjHobbi.TabIndex = 9;
            this.labelUjHobbi.Text = "Új hobbi:";
            this.labelUjHobbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUjHobbi.Location = new System.Drawing.Point(447, 245);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(175, 32);
            this.textBoxUjHobbi.TabIndex = 10;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHozzaad.Location = new System.Drawing.Point(492, 294);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(130, 40);
            this.buttonHozzaad.TabIndex = 11;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = false;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMentes.Location = new System.Drawing.Point(334, 359);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(130, 40);
            this.buttonMentes.TabIndex = 12;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = false;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBetoltes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBetoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBetoltes.Location = new System.Drawing.Point(492, 359);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(130, 40);
            this.buttonBetoltes.TabIndex = 13;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = false;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // dateTimePickerSzulDat
            // 
            this.dateTimePickerSzulDat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerSzulDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerSzulDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSzulDat.Location = new System.Drawing.Point(202, 66);
            this.dateTimePickerSzulDat.MaxDate = new System.DateTime(2020, 10, 27, 0, 0, 0, 0);
            this.dateTimePickerSzulDat.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerSzulDat.Name = "dateTimePickerSzulDat";
            this.dateTimePickerSzulDat.Size = new System.Drawing.Size(197, 32);
            this.dateTimePickerSzulDat.TabIndex = 4;
            this.dateTimePickerSzulDat.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // saveFileDialogMentes
            // 
            this.saveFileDialogMentes.DefaultExt = "txt";
            this.saveFileDialogMentes.FileName = "regisztracio";
            this.saveFileDialogMentes.Filter = "Szövegfájl (*.txt)|*txt|Minden fájl (*.*)|*.*";
            this.saveFileDialogMentes.RestoreDirectory = true;
            // 
            // openFileDialogBetoltes
            // 
            this.openFileDialogBetoltes.FileName = "regisztracio";
            this.openFileDialogBetoltes.Filter = "Szövegfájl (*.txt)|*txt|Minden fájl (*.*)|*.*";
            this.openFileDialogBetoltes.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.dateTimePickerSzulDat);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.labelKedvHobbi);
            this.Controls.Add(this.radioButtonNemN);
            this.Controls.Add(this.radioButtonNemF);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSzulDat);
            this.Controls.Add(this.labelNev);
            this.Name = "Form1";
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzulDat;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.RadioButton radioButtonNemF;
        private System.Windows.Forms.RadioButton radioButtonNemN;
        private System.Windows.Forms.Label labelKedvHobbi;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzulDat;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMentes;
        private System.Windows.Forms.OpenFileDialog openFileDialogBetoltes;
    }
}

