using System.Collections;
using System.Data;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace Constructora
{
    public partial class Form1 : Form
    {
        private Empresa empresa;
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa();
            comboBox1.Items.Add("Ingeniero");
            comboBox1.Items.Add("Maestro de Obra");
            comboBox1.Items.Add("Ayudante");
            comboBox1.SelectedIndex = 0;

            table.Columns.Add("Clave", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Puesto", typeof(string));
            table.Columns.Add("Salario", typeof(int));
            table.Columns.Add("Prima Dominical", typeof(int));
            table.Columns.Add("Horas Extras", typeof(int));
            table.Columns.Add("Seguro", typeof(int));
            dataGridView1.DataSource = table;
        }

        private void limpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            pictureBox1.Image = null;
            comboBox1.SelectedIndex = 0;
            textBox1.Focus();
       
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto1 = new OpenFileDialog();
            foto1.Filter = "(*.png; *.jpg) | *.png; *.jpg";
            if (foto1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(foto1.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = textBox1.Text;
                string nombre = textBox2.Text;
                string puesto = comboBox1.Text;
                int salario = Convert.ToInt32(textBox4.Text);

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Por favor, seleccione una foto. ");
                    return;
                }
                Trabajador trabajador;


                if (puesto == "Ingenerio")
                    trabajador = new Ingeniero(clave, nombre, salario, puesto, pictureBox1.Image);
                else if (puesto == "Maestro de Obra")
                    trabajador = new MaestroObra(clave, nombre, salario, puesto, pictureBox1.Image);
                else
                    trabajador = new Ayudante(clave, nombre, salario, puesto, pictureBox1.Image);

                empresa.agregaTrabajador(trabajador);
                MessageBox.Show("Trabajador agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, int.Parse(textBox4.Text),
                int.Parse(textBox3.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));

            limpiarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
