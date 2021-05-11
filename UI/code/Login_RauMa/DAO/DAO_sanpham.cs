using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class DAO_sanpham
    {
        private static string _conn = @"Data Source=.;Initial Catalog=ql_rauma;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(_conn);
        public List<DTO_sanpham> laydssp()
        {
            return 
        }
    }
   
}
