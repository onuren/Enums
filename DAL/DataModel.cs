using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }

        public ModelSonuc KategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Products WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi == 1)
                {
                    cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return ModelSonuc.Basarili;
                }
                else
                {
                    return ModelSonuc.Kullanimda;
                }
            }
            catch(Exception ex)
            {
                return ModelSonuc.Basarisiz;
            }
            finally
            {

            }
        }
    }
}
