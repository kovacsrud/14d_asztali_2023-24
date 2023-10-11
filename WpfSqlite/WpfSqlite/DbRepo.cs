using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSqlite
{
    public class DbRepo
    {
        public DataView GetData(string sqlString)
        {
            DataTable table=new DataTable();
            Constants.conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sqlString,Constants.conn);
            var reader=cmd.ExecuteReader();
            table.Load(reader);
            Constants.conn.Close();

            return table.DefaultView;
        } 

        public void InsertKutya(int fajtaid,int nevid,int eletkor,string utolsoell)
        {
            Constants.conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(Constants.conn);
            cmd.CommandText = "insert into kutya (fajtaid,nevid,eletkor,utolsoell) values (@fajtaid,@nevid,@eletkor,@utolsoell)";

            cmd.Parameters.Add("@fajtaid",DbType.Int32).Value = fajtaid;
            cmd.Parameters.Add("@nevid",DbType.Int32 ).Value = nevid;
            cmd.Parameters.Add("@eletkor",DbType.Int32).Value = eletkor;
            cmd.Parameters.Add("@utolsoell",DbType.String).Value = utolsoell;

            cmd.ExecuteNonQuery();

            Constants.conn.Close();

        }

        public void UpdateKutya(int id,int fajtaid,int nevid,int eletkor,string utolsoell)
        {
            Constants.conn.Open();
            SQLiteCommand cmd=new SQLiteCommand(Constants.conn);
            cmd.CommandText = "update kutya set fajtaid=@fajtaid,nevid=@nevid,eletkor=@eletkor,utolsoell=@utolsoell where Id=@id";

            cmd.Parameters.Add("@fajtaid", DbType.Int32).Value = fajtaid;
            cmd.Parameters.Add("@nevid", DbType.Int32).Value = nevid;
            cmd.Parameters.Add("@eletkor", DbType.Int32).Value = eletkor;
            cmd.Parameters.Add("@utolsoell", DbType.String).Value = utolsoell;
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            cmd.ExecuteNonQuery();
            Constants.conn.Close();

        }

        public void DeleteKutya(int id)
        {
            Constants.conn.Open();
            SQLiteCommand cmd= new SQLiteCommand(Constants.conn);
            cmd.CommandText = "delete from kutya where Id=@id";
            cmd.Parameters.Add("@id",DbType.Int32).Value = id;

            cmd.ExecuteNonQuery();
            Constants.conn.Close();
        }
    }
}
