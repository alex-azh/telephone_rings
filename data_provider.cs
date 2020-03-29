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
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_Abonents where inn='" + inn + "'", lo_conn))
                {
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

        public DataTable update()
        {
            DataTable dtUsers = new DataTable("Rings");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_Rings", lo_conn))
                {
                    var lo_dr = lo_cmd.ExecuteReader();

                    if (lo_dr.HasRows)
                    {
                        dtUsers.Load(lo_dr);
                    }
                    else
                    {
                        // вызвать исключение и поймать его в пользовательском интерфейсе
                    }
                }
            }
            return dtUsers;
        }


    }
}
