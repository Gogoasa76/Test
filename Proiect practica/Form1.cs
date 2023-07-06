using System.Data;
using System.Data.SqlClient;

namespace Proiect_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //con string
        SqlConnection con = new SqlConnection("");
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = new SqlCommand("insert into Tabel values ('" + textBox1.Text + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Merge");
            con.Close();
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Tabel", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Delete Tabel where", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete");
        }
    }
}