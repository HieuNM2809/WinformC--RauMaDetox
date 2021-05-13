using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_loaisp
    {
        private static string _connectionString = @"Data Source=DESKTOP-CJFK679\SQLEXPRESS;Initial Catalog=ql_rauma;Integrated Security=True";

        private SqlConnection _conn = new SqlConnection(_connectionString);
        public List<DTO_loaisp> LayDSloaisp()
        {
            List<DTO_loaisp> lstloaisp = new List<DTO_loaisp>();

            _conn.Open();

            string sql = "SELECT * FROM phanloaisp WHERE TrangThai = 1";

            SqlCommand cmd = new SqlCommand(sql, _conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DTO_loaisp sp = new DTO_loaisp
                    {
                        Maloaisp=sdr.GetString(0),
                        Loaisp=sdr.GetString(1),
                        Trangthaisp=sdr.GetBoolean(2)

                    };

                    lstloaisp.Add(sp);
                }
            }

            _conn.Close();

            return lstloaisp;
        }

    }


}
    

