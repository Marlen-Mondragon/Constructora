namespace Constructora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 15);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 0;
            label1.Text = "Trabajadores de la Constructora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 11F);
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 1;
            label2.Text = "Clave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 11F);
            label3.Location = new Point(33, 152);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 11F);
            label4.Location = new Point(33, 236);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 3;
            label4.Text = "Puesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 11F);
            label5.Location = new Point(33, 307);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 4;
            label5.Text = "Salario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(964, 77);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 5;
            label6.Text = "Foto:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Font = new Font("Book Antiqua", 10F);
            textBox1.Location = new Point(131, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 32);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Yellow;
            textBox2.Font = new Font("Book Antiqua", 10F);
            textBox2.Location = new Point(133, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 32);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Yellow;
            textBox4.Font = new Font("Book Antiqua", 10F);
            textBox4.Location = new Point(133, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 32);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(964, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(33, 368);
            button1.Name = "button1";
            button1.Size = new Size(183, 73);
            button1.TabIndex = 11;
            button1.Text = "Seleccionar Foto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(563, 368);
            button2.Name = "button2";
            button2.Size = new Size(183, 73);
            button2.TabIndex = 12;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Location = new Point(980, 368);
            button3.Name = "button3";
            button3.Size = new Size(183, 73);
            button3.TabIndex = 13;
            button3.Text = "Mostrar Datos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(520, 623);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 54);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Yellow;
            comboBox1.Font = new Font("Book Antiqua", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ingeniero" });
            comboBox1.Location = new Point(133, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 32);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "                        Seleccione:";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(453, 77);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(469, 268);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prestaciones:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Yellow;
            textBox6.Font = new Font("Book Antiqua", 10F);
            textBox6.Location = new Point(189, 203);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 32);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Yellow;
            textBox5.Font = new Font("Book Antiqua", 10F);
            textBox5.Location = new Point(189, 125);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 32);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Yellow;
            textBox3.Font = new Font("Book Antiqua", 10F);
            textBox3.Location = new Point(189, 60);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 32);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 10F);
            label9.Location = new Point(57, 205);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 29);
            label9.TabIndex = 2;
            label9.Text = "Seguro:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 10F);
            label8.Location = new Point(34, 130);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 29);
            label8.TabIndex = 1;
            label8.Text = "Horas Extras:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 10F);
            label7.Location = new Point(34, 62);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 29);
            label7.TabIndex = 0;
            label7.Text = "Prima Dominical:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 469);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1234, 250);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1260, 748);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Construtora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
