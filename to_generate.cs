using System;
using System.IO;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;

namespace Telephone_Ring
{
    class to_generate
    {
        public string datetime()
        {
            Random rand = new Random();
            string year, month = "", day = "", hour = "", minute = "", second = "", result;
            year = rand.Next(2018, 2021).ToString();

            while (month.Length != 2)
                if (month.Length == 1)
                    month = "0" + month;
                else
                    month = rand.Next(1, 13).ToString();

            while (day.Length != 2)
                if (day.Length == 1)
                    day = "0" + day;
                else
                    day = rand.Next(1, 29).ToString();


            while (hour.Length != 2)
                if (hour.Length == 1)
                    hour = "0" + hour;
                else
                    hour = rand.Next(0, 24).ToString();


            while (minute.Length != 2)
                if (minute.Length == 1)
                    minute = "0" + minute;
                else
                    minute = rand.Next(0, 60).ToString();


            while (second.Length != 2)
                if (second.Length == 1)
                    second = "0" + second;
                else
                    second = rand.Next(0, 60).ToString();


            //    2001-02-17 02:38:40

            result = year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second;
            return result;
        }


        public string t_Rings(string aid, string city, string datetime, string minutes)
        {   
            string result;
            result = "select adding('" + aid + "','" + city + "','" + datetime + "'," + minutes + ")";
            return result;
        }

        public string adding()
        {
            var dp = new data_provider();
            string aid = dp.get_rand("AID");
            string City = dp.get_rand("City_name");
            Random rand = new Random();
            //select adding('A00040','Туапсе', '2020-10-15 19:59:29',32);
            return (t_Rings(aid, City, datetime(), rand.Next(1, 41).ToString()));
        }



    }
}
