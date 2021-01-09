using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
namespace DriverClient
{
    class MySQLiteClass
    {
        public static SQLiteConnection sqlitecon;

        static string str1 = System.Windows.Forms.Application.StartupPath + "\\201Exam_db";
        public static SQLiteConnection Getsqlitecon()
        {
            string str_sqlitecon = @"Data Source = " + str1; //根据自己的设置
            SQLiteConnection sqlitecon = new SQLiteConnection(str_sqlitecon);
            sqlitecon.Open();
            return sqlitecon;
        }

        public static void Getmysqlcom(string sqlstr)
        {
            sqlitecon = Getsqlitecon();
            SQLiteCommand sqlitecom = new SQLiteCommand(sqlstr, sqlitecon);
            sqlitecom.ExecuteNonQuery();
            sqlitecom.Dispose();
            sqlitecon.Dispose();
        }

        public static SQLiteDataReader Getmysqlread(string sqlstr)
        {
            sqlitecon = Getsqlitecon();
            SQLiteCommand sqlitecom = new SQLiteCommand(sqlstr, sqlitecon);
            SQLiteDataReader sqliteread = sqlitecom.ExecuteReader();
            return sqliteread;
        }

        public static DataSet Getsqliteset(string sqlstr, string tableName)
        {
            sqlitecon = Getsqlitecon();
            SQLiteDataAdapter sqlitedata = new SQLiteDataAdapter(sqlstr, sqlitecon);
            DataSet sqlitedataset = new DataSet();
            sqlitedata.Fill(sqlitedataset, tableName);
            sqlitecon.Dispose();
            sqlitedata.Dispose();
            return sqlitedataset;
        }

        public static void sqlClose(SQLiteConnection con)
        {
            con.Close();
            con.Dispose();
        }
    }
}
