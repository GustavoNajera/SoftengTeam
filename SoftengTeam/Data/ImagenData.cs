using SoftengTeam.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SoftengTeam.Data
{
    public class ImagenData
    {
        private string connectionString;

        public ImagenData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Imagen> obtenerImagenes()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select * from imagen where publicidadImagen = 0";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetImagen = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetImagen, "Imagen");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetImagen.Tables["Imagen"].Rows;
            List<Imagen> list = new List<Imagen>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                int idImagen = Int32.Parse(currentRow["idImagen"].ToString());
                String nombreImagen = currentRow["rutaImagen"].ToString();
                Boolean publicidadImagen = (Boolean)currentRow["publicidadImagen"];
                Imagen imagen = new Imagen(idImagen,nombreImagen,publicidadImagen);
                list.Add(imagen);
            }

            return list;
        }
    }
}