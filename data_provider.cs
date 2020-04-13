using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using System.IO;

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

        public void add_database()
        {
            string path = @"C:\console.sql";
            string sql_req;

                StreamReader sr = new StreamReader(path);
                {
                    sql_req =sr.ReadToEnd();
                }
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                //преобразуем пароль для сравнения
                using (var lo_cmd = new NpgsqlCommand(@sql_req, lo_conn))
                {
                    lo_cmd.ExecuteNonQuery();
                }
            }
        }
        public string proverka_connect()
        {
            int lv_users = 0, lv_Abonents = 0, lv_Rings = 0, lv_City = 0, lv_Sale = 0;
            try { using (var lo_conn = new NpgsqlConnection(_sConnStr)) { lo_conn.Open(); } }
            catch
            { throw new Exception("БД не удается найти. Неверный логин/пароль или нет доступа."); }

            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                //преобразуем пароль для сравнения
                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"SELECT count(*) from public.t_Users", lo_conn))
                    {
                        lv_users = Convert.ToInt32(lo_cmd.ExecuteScalar());
                    }
                }
                catch { throw new Exception("Нет доступа к таблице t_users"); }

                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"SELECT count(*) from public.t_Abonents", lo_conn))
                    {
                        lv_Abonents = Convert.ToInt32(lo_cmd.ExecuteScalar());
                    }
                }
                catch { throw new Exception("Нет доступа к таблице t_Abonents"); }
                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"SELECT count(*) from public.t_Rings", lo_conn))
                    {
                        lv_Rings = Convert.ToInt32(lo_cmd.ExecuteScalar());
                    }
                }
                catch { throw new Exception("Нет доступа к таблице t_Rings"); }
                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"SELECT count(*) from public.t_City", lo_conn))
                    {
                        lv_City = Convert.ToInt32(lo_cmd.ExecuteScalar());
                    }
                }
                catch { throw new Exception("Нет доступа к таблице t_City"); }
                try
                {
                    using (var lo_cmd = new NpgsqlCommand(@"SELECT count(*) from public.t_Sale", lo_conn))
                    {
                        lv_Sale = Convert.ToInt32(lo_cmd.ExecuteScalar());
                    }
                }
                catch { throw new Exception("Нет доступа к таблице t_Sale"); }
                if (lv_Abonents != 0 && lv_Sale != 0 && lv_users != 0 && lv_City != 0) return "ok";
                else return "Какая-то база данных пустая. Производится заполнение...";
            }

        }
        public bool authorization(string login, byte[] pass)
        {

            string pass_from_prog, pass_from_bd = "";
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                //преобразуем пароль для сравнения
                using (var lo_cmd = new NpgsqlCommand(@"SELECT encode(@pass_byte, 'hex')", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@pass_byte", pass);
                    object lo_dr = lo_cmd.ExecuteScalar();
                    pass_from_prog = Convert.ToString(lo_dr);
                }
                try
                {//получим хеш пароля из бд, что получили по логину
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
            }//сравниваем полученные пароли
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
                        throw new Exception("Такого абонента нет.");
                    }
                }
            }
            return dt_Abon;
        }

        public string abon_inn(string AID) //получить ИНН по AID
        {
            string otvet = "";
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select inn from t_Abonents where AID=@AID", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@AID", AID);
                    otvet = (string)lo_cmd.ExecuteScalar();
                }
            }
            return otvet;
        }

        public DataTable abon_rings(string inn)
        {
            DataTable dt_Abon = new DataTable("Info_abon");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(@"Select * from t_rings where AID=(select AID from t_Abonents where inn=@inn)", lo_conn))
                {
                    lo_cmd.Parameters.AddWithValue("@inn", inn);
                    var lo_dr = lo_cmd.ExecuteReader();

                    if (lo_dr.HasRows)
                    {
                        dt_Abon.Load(lo_dr);
                    }
                    else
                    {
                        //исключение избыточно, т.к. до этого проверялось
                    }
                }
            }
            return dt_Abon;
        }
        public void new_call(string comanda)
        {
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand(comanda, lo_conn))
                {
                    if (lo_cmd.ExecuteNonQuery() != 1)
                    {
                    }
                }
            }
        }

        public string get_rand(string parametr)
        {
            try
            {
                switch (parametr)
                {
                    case "AID":
                        {
                            string otvet = "";
                            using (var lo_conn = new NpgsqlConnection(_sConnStr))
                            {
                                lo_conn.Open();
                                using (var lo_cmd = new NpgsqlCommand(@"SELECT AID FROM t_Abonents ORDER BY RANDOM() LIMIT 1", lo_conn))
                                {
                                    otvet = (string)lo_cmd.ExecuteScalar();
                                }
                            }
                            return otvet;
                        }
                    case "City_name":
                        {
                            string otvet = "";
                            using (var lo_conn = new NpgsqlConnection(_sConnStr))
                            {
                                lo_conn.Open();
                                using (var lo_cmd = new NpgsqlCommand(@"SELECT City_name FROM t_City ORDER BY RANDOM() LIMIT 1", lo_conn))
                                {
                                    otvet = (string)lo_cmd.ExecuteScalar();
                                }
                            }
                            return otvet;
                        }
                    default:
                        throw new Exception("Несуществующий запрос домена"); ;
                }

            }
            catch { throw new Exception("Проблемы с бд t_City or t_Abonents"); }
            
        }


        public void delete()
        {
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();

                using (var lo_cmd = new NpgsqlCommand(@"DELETE FROM t_Rings WHERE (select count(*) from t_Rings)>0", lo_conn))
                {
                    lo_cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable update()
        {
            DataTable dtRings = new DataTable("Rings");
            using (var lo_conn = new NpgsqlConnection(_sConnStr))
            {
                lo_conn.Open();
                using (var lo_cmd = new NpgsqlCommand
                    (@"select inn, City_name, datetime, minutes, time_of_day, sale, cost from t_rings
                        INNER JOIN t_Abonents tA on t_rings.AID = tA.AID order by tA.AID", lo_conn))
                {
                    var lo_dr = lo_cmd.ExecuteReader();
                    
                    if (lo_dr.HasRows)
                    {
                        dtRings.Load(lo_dr);
                    }
                }
            }
            return dtRings;
        }


    }
}
