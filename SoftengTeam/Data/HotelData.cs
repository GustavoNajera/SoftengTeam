using SoftengTeam.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace SoftengTeam.Data
{
    public class HotelData
    {
        private string connectionString;

        public HotelData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Hotel> obtenerHoteles()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select * from Hotel";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetImagen = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetImagen, "Hotel");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetImagen.Tables["Hotel"].Rows;
            List<Hotel> list = new List<Hotel>();
            foreach (DataRow currentRow in dataRowCollection)
            {
             
                String descripcionHotel = currentRow["descripcionHotel"].ToString();
                String sobreNosotrosHotel = currentRow["sobreNosotrosHotel"].ToString();
                String contactoHotel = currentRow["contactoHotel"].ToString();
                Hotel hotel = new Hotel(descripcionHotel,sobreNosotrosHotel,contactoHotel);
                list.Add(hotel);
            }

            return list;
        }
    }
}