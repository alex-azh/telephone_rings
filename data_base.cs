using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Ring
{
    class data_base
    {
        public Stack<string> inn = new Stack<string>();
        public Stack<string> address = new Stack<string>();
        public Stack<string> phone = new Stack<string>();
        public string inn_path =  @"C:\Users\prog\Desktop\Проект\Абоненты\inn.txt",
            phone_path= @"C:\Users\prog\Desktop\Проект\Абоненты\phone.txt",
            address_path = @"C:\Users\prog\Desktop\Проект\Абоненты\address.txt";

        public string out_info_abon(string parametr)
        {
            switch (parametr)
            {
                case "inn":
                    return inn.Pop().ToString();
                case "phone":
                    return phone.Pop().ToString();
                case "address":
                    return address.Pop().ToString();
                default:
                    return "error";
            }
        }

        public void add_abon()
        {
            try
            {
                using (StreamReader sr = new StreamReader(inn_path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        inn.Push(line);
                    }
                }
                using (StreamReader sr = new StreamReader(phone_path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        phone.Push(line);
                    }
                }
                using (StreamReader sr = new StreamReader(address_path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line =sr.ReadLine()) != null)
                    {
                        address.Push(line);
                    }
                }
            }
            catch { };
        }



    }
}
