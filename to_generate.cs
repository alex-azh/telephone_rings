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
        {   //select adding('U0001','Москва','2001-02-16 14:38:40',12);
            string result;
            result = "select new_schema.adding('" + aid + "','" + city + "','" + datetime + "'," + minutes + ")";
            return result;
        }

        public string adding()
        {
            int i;
            StreamReader a = new StreamReader("C:/Users/maser/Desktop/City.txt");
            string[] City = new string[322];
            i = 0;
            while (!a.EndOfStream)
            {
                City[i] = a.ReadLine();
                i++;
            }

            StreamReader b = new StreamReader("C:/Users/maser/Desktop/id.txt");
            string[] aid = new string[150];
            i = 0;
            while (!b.EndOfStream)
            {
                aid[i] = b.ReadLine();
                i++;
            }

            Random rand = new Random();
            return (t_Rings(aid[rand.Next(0, 150)], City[rand.Next(0, 322)], datetime(), rand.Next(1, 41).ToString()));
        }



    }
}
