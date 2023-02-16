using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atividade03
{
    public partial class Clientes : Form
    {
        SqlConnection conn = new SqlConnection(" Data Source=OSA0625259W10-1;Initial Catalog=RELACIONAMENTOS_200;Integrated Security=True"); //  > CON variavel para conexão
        SqlCommand comando = new SqlCommand(); //Comando > Variavel para comando 
        SqlDataReader dr;// Consultar os dados 
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            comando.Connection = conn; //Conectando o formulario com o banco de dados 
            Carregarlista();
        }

        private void Carregarlista()
        
        {
            // limpa as informações após salvar
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            conn.Open(); //Executar abertura do banco de dados 
            comando.CommandText = "select * from Clientes";
            dr = comando.ExecuteReader();


            if (dr.HasRows) // se estiver linha 
            {

                while (dr.Read()) // lopping // percorrer 
                
                
                {
                    listBox1.Items.Add(dr[0].ToString()); // Se inicia em zero listbox 
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[3].ToString());
                    listBox4.Items.Add(dr[4].ToString());
                    listBox5.Items.Add(dr[5].ToString());
                }


            }
            conn.Close(); // fechar banco de dados 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox l = sender as ListBox; // 1 Variavel 
            if (l.SelectedIndex != -1) //irá setar a linha toda selecionada  

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;

                // Quando a linha for selecionada trazer para textbox.
                textBox1.Text = listBox1.SelectedItem.ToString();
                textBox2.Text = listBox2.SelectedItem.ToString();
                textBox3.Text = listBox3.SelectedItem.ToString();
                textBox4.Text = listBox4.SelectedItem.ToString();
                textBox5.Text = listBox5.SelectedItem.ToString();
               
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Focus();// se posicona no textbox2 para digitar 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open(); // abrir banco de dados 
            comando.CommandText = "insert into Clientes(nome,datanascimento,telefone,email) " +
            " values ('" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "', '"
            + textBox5.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close(); //fechar banco de dados 
            Carregarlista();
            textBox1.Clear(); // limpar dados 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Focus(); // posicionar cursor  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open(); // abrir banco de dados 
            comando.CommandText = " update Clientes set nome = '" + textBox2.Text + "', datanascimento = '" + textBox3.Text + "', " +
            " telefone = '" + textBox4.Text + "',  email = '" + textBox5.Text + "' " + " where codigo = '" + listBox1.SelectedItem.ToString() + "'";
            comando.ExecuteNonQuery();
            conn.Close(); // fechar banco de dados 
            Carregarlista(); // limpar dados  
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Focus();  // posicionar cursor 
        }
    }
}
