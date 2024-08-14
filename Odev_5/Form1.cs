using System.Data.SqlClient;

namespace Odev_5
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi = "";

        public Form1()
        {            
            InitializeComponent();
            ORM orm = new ORM();
            orm.Orm();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-P1TC8HDR\MSSQL;Initial Catalog=RadoreDB;uid=sa;Password=123;");
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM OdemeTipleri", sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbOdemeTipi.Items.Add(reader["DISPLAY_NAME"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);
            OdemeIslemiFactory odemeIslemiFactory = new OdemeIslemiFactory();
            IOdemeTipi odemeTipi = odemeIslemiFactory.NesneOlustur(secilenOdemeTipi);
            OdemeIslemi odemeIslemi = new OdemeIslemi(odemeTipi);
            lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT CLASS_NAME FROM OdemeTipleri WHERE DISPLAY_NAME = @displayName", sqlConnection);
                command.Parameters.AddWithValue("@displayName", secilenOdemeTipi);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        secilenOdemeTipi = reader["CLASS_NAME"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
