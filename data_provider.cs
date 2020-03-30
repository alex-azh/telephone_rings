using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;


namespace Telephone_Ring
{
    class data_provider
    {
        private readonly string _sConnStr = new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Database = "rings",
            Username = "postgres",
            Password = "postgres",
            MaxAutoPrepare = 10,
            AutoPrepareMinUsages = 2
        }.ConnectionString;
        public byte[] CalcHash(string raw_password)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(raw_password);
            return DigestUtilities.CalculateDigest("GOST3411", bytes);
        }
        public bool authorization(string login, byte[] pass)
        {

            string pass_from_prog, pass_from_bd = "";
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"SELECT encode(@pass_byte, 'hex')", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@pass_byte", pass);
                    object lo_dr = lo_cmd.ExecuteScalar();
                    pass_from_prog = Convert.ToString(lo_dr);
                }
                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"(SELECT pass from t_users where login =@login)", lo_conn))
                    {
                        lo_cmd.Parameters.AddWithValue("@login", login);
                        object lo_dr = lo_cmd.ExecuteScalar();
                        pass_from_bd = (Convert.ToString(lo_dr)).Substring(2);
                    }
                }
                catch//в случае не нахождения логина
                {
                    return false;
                }
            }
            if (pass_from_bd == pass_from_prog)
                return true;
            else return false;

        }
        
        public DataTable info_abon(string inn)
        {
            DataTable dt_Abon = new DataTable("Info_abon");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_Abonents where inn=@inn", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@inn", inn);
                    var lo_dr = lo_cmd.ExecuteReader();

                    if (lo_dr.HasRows)
                    {
                        dt_Abon.Load(lo_dr);
                    }
                    else
                    {
                        // вызвать исключение и поймать его в пользовательском интерфейсе
                    }
                }
            }
            return dt_Abon;
        }

        public DataTable abon_rings(string inn)
        {
            DataTable dt_Abon = new DataTable("Info_abon");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_Rings where AID=(select AID from t_Abonents where inn=@inn)", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@inn", inn);
                    var lo_dr = lo_cmd.ExecuteReader();

                    if (lo_dr.HasRows)
                    {
                        dt_Abon.Load(lo_dr);
                    }
                    else
                    {
                        // вызвать исключение и поймать его в пользовательском интерфейсе
                    }
                }
            }
            return dt_Abon;
        }

        public string get_id_abon(string iv_tab_name, string iv_pref)
        {
            string lv_id;
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"get_id", lo_conn))
                {
                    lo_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    lo_cmd.Parameters.AddWithValue("@iv_table_name", iv_tab_name);
                    lo_cmd.Parameters.AddWithValue("@iv_column_name", "uid");
                    lo_cmd.Parameters.AddWithValue("@iv_pref", iv_pref);
                    lv_id = (string)lo_cmd.ExecuteScalar();

                    // обработать исключение и поймать его в пользовательском интерфейсе
                }
            }
            return lv_id;
        }

        public void reg_abon(ref Stack<string> inn, ref Stack<string> phone,ref Stack<string> address) //n -будущих записей
        {
            Random r = new Random();
            var db = new data_base();
            //var lv_id = get_id_abon("t_Abonents", "A");
                using (var lo_conn = new NpgsqlConnection(_sConnStr))
                {
                    lo_conn.Open();
                    string lv_sql = @"insert into t_Abonents values (@AID, @inn, @phone, @address)";
                    using (var lo_cmd = new NpgsqlCommand(lv_sql, lo_conn))
                    {
                        lo_cmd.Parameters.AddWithValue("@AID", "A"+r.Next(1000).ToString());
                        lo_cmd.Parameters.AddWithValue("@inn", inn.Pop().ToString());
                        lo_cmd.Parameters.AddWithValue("@phone", phone.Pop().ToString());
                        lo_cmd.Parameters.AddWithValue("@address", address.Pop().ToString());
                        if (lo_cmd.ExecuteNonQuery() != 1)
                        {
                            // вызвать исключение и поймать его в пользовательском интерфейсе
                        }
                    }
                }

        }

        public DataTable update()
        {
            DataTable dtRings = new DataTable("Rings");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_Rings", lo_conn))
                {
                    var lo_dr = lo_cmd.ExecuteReader();

                    if (lo_dr.HasRows)
                    {
                        dtRings.Load(lo_dr);
                    }
                    else
                    {
                        // вызвать исключение и поймать его в пользовательском интерфейсе
                    }
                }
            }
            return dtRings;
        }


    }
}
