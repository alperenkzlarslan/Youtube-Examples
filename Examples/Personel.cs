using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class Personel
    {
        private string ıdNo;

        public string IDNO
        {
            get
            {
                return ıdNo.Substring(0, 4);
            }
            set
            {
                bool control = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool ısNumber = char.IsNumber(value[i]);

                        if (ısNumber)
                        {
                            //yapmam gereken bir şey yok 
                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }
                    
                    if (control)
                    {
                        Console.WriteLine("Tc kimlik no da geçersiz karakter bulundu");
                    }
                    else
                    {
                        ıdNo = value;

                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik no 11 karakter olamlı !!! ");
                }
            }
        }
    }
}
