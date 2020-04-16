namespace Project.DAL.Model
{
    public class ProgramUser:User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        

        public ProgramUser(string username, string password, bool isEnabled,string firstName, string lastName, string jobTitle):base(username,password,isEnabled)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "FirstName" && string.IsNullOrWhiteSpace(FirstName))
                {
                    return "First Name should not be empty.";
                }
                else if (columnName == "LastName" && string.IsNullOrWhiteSpace(LastName))
                {
                    return "Last Name should not be empty.";
                }
                else if (columnName == "Username" && string.IsNullOrWhiteSpace(Username))
                {
                    return "Username should not be empty.";
                }
                else if (columnName == "Password" && string.IsNullOrWhiteSpace(Password))
                {
                    return "Password should not be empty.";
                }

                return "";
            }
        }


    }
}
