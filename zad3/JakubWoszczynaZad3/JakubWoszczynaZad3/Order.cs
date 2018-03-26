using System.Data.SqlClient;
using System.Data;
using System;

namespace JakubWoszczynaZad3
{
    class Order
    {

        public static DataTable GetAll(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select  o.DateOfOrder, p.Price,c.IdLaptop," +
                "c.IdMp3,c.IdSmartphone,c.IdTablet,c.IdTv from " +
                " Orders o join Product p on o.IdProduct = p.Id " +
                " join Category c on p.IdCategory = c.Id", connection);


            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
