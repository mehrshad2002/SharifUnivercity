using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SharifUnivercity
{
    public class StudentAccount
    {
        public void CreateStudentAccount()
        {
            bool Flag = File.Exists("../../../DataFile/StudentData/Students.json");// student file
            if( Flag != true)
            {
                List<Account> accounts = new List<Account>();
                SaveLoad sl = new SaveLoad();
                accounts.Add( new Account("Mehrshad" , "mehr1234" , 100 , 4001234 , new DateTime(2002,10,11) , 500 , null));
                accounts.Add(new Account("Negin", "Negin1234", 100, 4001235, new DateTime(2002, 10, 11), 500 , null));
                accounts.Add(new Account("Bahar", "Bahar1234", 110 , 4005671, new DateTime(2002, 10, 11), 500 , null));
                accounts.Add(new Account("Aria", "Aria1234", 100, 4001236, new DateTime(2002, 10, 11), 500 , null));
                accounts.Add(new Account("Borna", "borna1234", 110, 4005672, new DateTime(2002, 10, 11), 500 , null));

                string path = "../../../DataFile/StudentData/Students.json";
                sl.Save(accounts , path );
            }
        }
    }
}
