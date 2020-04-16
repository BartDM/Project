namespace Project.BDO
{
    public class VM:Computer
    { // Virtual Machine computer
        public string Type { get; }
        public virtual PM Host { get; set; }
    }
}

