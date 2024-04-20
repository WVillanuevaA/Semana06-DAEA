using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Semana06
{
    /// <summary>
    /// Lógica de interacción para RegistrarCliente.xaml
    /// </summary>
    public partial class RegistrarCliente : Window
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }
        private string conexion = "Data Source=LAB1504-29\\SQLEXPRESS;Initial Catalog=Neptuno;User Id=Eduardo;Password=123456";
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string consulta = "insert into clintes values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            SqlCommand comando = new SqlCommand(consulta);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Agregado");

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, object e)
        {
          
        }
    }
}
