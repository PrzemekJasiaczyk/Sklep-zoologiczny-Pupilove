using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Logic
{
    internal class KlientService
    {
        public static readonly string con_string = " Data Source=KOZAK; Initial Catalog=SklepZoologiczny;Persist Security Info-True;User ID=sa; Password=123;";
        public static SqlConnection connection = new SqlConnection(con_string);

        // nie testowane 
        /*public static bool Walidacja_Uzytkownika(string uzytkownik, string haslo)
        {
            bool czyPoprawny= false;

            string zapytanie = @"Select * from users where username ='"+uzytkownik+"' and haslo ='" +haslo+"'  ";

            SqlCommand cmd = new SqlCommand(zapytanie, connection);
            DataTable tabela = new DataTable()
;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);


            if(tabela.Rows.Count>0)
            {
                czyPoprawny = true;
            }

            return czyPoprawny;
        }
        */

    }
}
