using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PruebaDeEscritorio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-C4043JNM;Initial Catalog=PruebaEscritorio;Integrated Security=True");
            cn.Open();
            SqlCommand adaptador = new SqlCommand();
            adaptador.Connection = cn;
            adaptador.CommandText = "insert into Usuarios values (" + txbCodigoRegistar.Text + ",'" + txbNombreRegistrar.Text + "','" + txbApellidoRegistrar.Text + "','" + txbDNIRegistrar.Text + "','" + txbTelefonoRegistrar.Text + "')";
            adaptador.ExecuteNonQuery();
            MessageBox.Show("Se registro correctamente");
            cn.Close();
        }

        private void btnBuscarActializar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-C4043JNM;Initial Catalog=PruebaEscritorio;Integrated Security=True");
            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Usuarios where codigo=" + txbCodigoActualizar.Text + "",cn);
            DataSet t = new DataSet();
            adaptador.Fill(t);  
            
            
        }
    }
}
