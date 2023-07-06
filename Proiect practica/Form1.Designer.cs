namespace Proiect_practica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonInsert = new Button();
            Nume = new Label();
            Prenume = new Label();
            Telefon = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(71, 165);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(75, 23);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += button1_Click;
            // 
            // Nume
            // 
            Nume.AutoSize = true;
            Nume.Location = new Point(71, 44);
            Nume.Name = "Nume";
            Nume.Size = new Size(40, 15);
            Nume.TabIndex = 1;
            Nume.Text = "Nume";
            // 
            // Prenume
            // 
            Prenume.AutoSize = true;
            Prenume.Location = new Point(71, 79);
            Prenume.Name = "Prenume";
            Prenume.Size = new Size(55, 15);
            Prenume.TabIndex = 2;
            Prenume.Text = "Prenume";
            // 
            // Telefon
            // 
            Telefon.AutoSize = true;
            Telefon.Location = new Point(71, 107);
            Telefon.Name = "Telefon";
            Telefon.Size = new Size(45, 15);
            Telefon.TabIndex = 3;
            Telefon.Text = "Telefon";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(722, 174);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(398, 23);
            textBox3.TabIndex = 7;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(174, 165);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Telefon);
            Controls.Add(Prenume);
            Controls.Add(Nume);
            Controls.Add(buttonInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInsert;
        private Label Nume;
        private Label Prenume;
        private Label Telefon;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonDelete;
    }
}