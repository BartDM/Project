namespace Project.DAL.Model
{
    public class VM:Computer
    { // Virtual Machine computer
        public string Type
        {
            get { return "Virtual"; }
        }

        //navigation properties
        //DB 1-on-1 relationship
        public virtual PM Host { get; set; }
    }

}

