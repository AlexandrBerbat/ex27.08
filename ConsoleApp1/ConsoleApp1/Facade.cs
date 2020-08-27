using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Facade
    {
        SqlConnection connection = new SqlConnection();
        ShowData ShowData1 = new ShowData();
        AddData AddData1 = new AddData();
        EditData EditData1 = new EditData();
        DeleteData DeleteData1 = new DeleteData();
        DefaultInquiries DefaultInq = new DefaultInquiries();


        public Facade(ShowData A, AddData E, EditData B, DeleteData C, DefaultInquiries D, SqlConnection conn)
        {
            ShowData1 = A;
            AddData1 = E;
            EditData1 = B;
            DeleteData1 = C;
            DefaultInq = D;
            connection = conn;

        }

        public void FacadeShowData(string sql)
        {
            ShowData1.Show(sql, connection);
        }

        public void FacadeAddData()
        {
            AddData1.Add(connection);
        }

        public void FacadeEditData()
        {

            EditData1.Edit(connection);
        }

        public void FacadeDeleteData()
        {
            DeleteData1.Delete(connection);
        }

        public void FacadeDefaultInq()
        {
            DefaultInq.Inquiries(connection);
        }
    }
}
