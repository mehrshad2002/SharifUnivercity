namespace SharifUnivercity
{
    public class Login_Validation
    {
        private Account studentobj;

        public Account Studentobj
        {
            get { return studentobj; }
            set { studentobj = value; }
        }

        public bool Login()
        {
            IO io = new IO();

            int cardNumber;
            while ( true )
            {
                try
                {
                    io.PrintAt("Enter your Student CardNumber : ");
                    cardNumber = io.GetInt();
                    break;
                }catch( Exception e)
                {
                    io.Print("Enter <integer> Number !");
                }
            }



            io.PrintAt("Enter Your Password :");
            string password = io.GetStr(); 

            Account account = CheckLogin(cardNumber , password);
            if (account != null)
            {
                Studentobj = account; // set a data 
                io.Print($"Welcome Back {Studentobj.Name}");
                return true;
            }
            io.Print("Invalid Password Or Student Card Number ");
            return false;
        }

        private Account CheckLogin(int cardNumber , string password)
        {
            SaveLoad sl = new SaveLoad();
            List<Account> accounts =  sl.LoadStudentData();

            foreach( Account account in accounts)
            {
                if( password == account.Password && cardNumber == account.StudentNumberCard)
                {
                    return account;
                }
            }

            return null; // time when we cant find user
        }
    }
}