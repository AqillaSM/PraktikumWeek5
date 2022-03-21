namespace PraktikumWeek5
{
    partial class FormMateri
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxAktif = new System.Windows.Forms.CheckBox();
            this.RadioButtonMerah = new System.Windows.Forms.RadioButton();
            this.RadioButtonBiru = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBoxMateri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(90, 46);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(544, 22);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(678, 45);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setting:";
            // 
            // CheckBoxAktif
            // 
            this.CheckBoxAktif.AutoSize = true;
            this.CheckBoxAktif.Location = new System.Drawing.Point(526, 104);
            this.CheckBoxAktif.Name = "CheckBoxAktif";
            this.CheckBoxAktif.Size = new System.Drawing.Size(54, 20);
            this.CheckBoxAktif.TabIndex = 5;
            this.CheckBoxAktif.Text = "Aktif";
            this.CheckBoxAktif.UseVisualStyleBackColor = true;
            this.CheckBoxAktif.CheckedChanged += new System.EventHandler(this.CheckBoxAktif_CheckedChanged);
            // 
            // RadioButtonMerah
            // 
            this.RadioButtonMerah.AutoSize = true;
            this.RadioButtonMerah.Location = new System.Drawing.Point(526, 140);
            this.RadioButtonMerah.Name = "RadioButtonMerah";
            this.RadioButtonMerah.Size = new System.Drawing.Size(109, 20);
            this.RadioButtonMerah.TabIndex = 6;
            this.RadioButtonMerah.TabStop = true;
            this.RadioButtonMerah.Text = "Warna Merah";
            this.RadioButtonMerah.UseVisualStyleBackColor = true;
            this.RadioButtonMerah.CheckedChanged += new System.EventHandler(this.RadioButtonMerah_CheckedChanged);
            // 
            // RadioButtonBiru
            // 
            this.RadioButtonBiru.AutoSize = true;
            this.RadioButtonBiru.Location = new System.Drawing.Point(526, 177);
            this.RadioButtonBiru.Name = "RadioButtonBiru";
            this.RadioButtonBiru.Size = new System.Drawing.Size(94, 20);
            this.RadioButtonBiru.TabIndex = 7;
            this.RadioButtonBiru.TabStop = true;
            this.RadioButtonBiru.Text = "Warna Biru";
            this.RadioButtonBiru.UseVisualStyleBackColor = true;
            this.RadioButtonBiru.CheckedChanged += new System.EventHandler(this.RadioButtonBiru_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output:";
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutput.Location = new System.Drawing.Point(451, 283);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(334, 51);
            this.LabelOutput.TabIndex = 9;
            this.LabelOutput.Text = "Output beneran";
            this.LabelOutput.Click += new System.EventHandler(this.LabelOutput_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(605, 383);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 10;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Koleksi:";
            // 
            // ListBoxMateri
            // 
            this.ListBoxMateri.FormattingEnabled = true;
            this.ListBoxMateri.ItemHeight = 16;
            this.ListBoxMateri.Location = new System.Drawing.Point(48, 141);
            this.ListBoxMateri.Name = "ListBoxMateri";
            this.ListBoxMateri.Size = new System.Drawing.Size(340, 308);
            this.ListBoxMateri.TabIndex = 12;
            this.ListBoxMateri.SelectedIndexChanged += new System.EventHandler(this.ListBoxMateri_SelectedIndexChanged);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 522);
            this.Controls.Add(this.ListBoxMateri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadioButtonBiru);
            this.Controls.Add(this.RadioButtonMerah);
            this.Controls.Add(this.CheckBoxAktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxAktif;
        private System.Windows.Forms.RadioButton RadioButtonMerah;
        private System.Windows.Forms.RadioButton RadioButtonBiru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxMateri;
    }
}

