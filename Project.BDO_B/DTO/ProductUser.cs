namespace Project.BDO
{
    public class ProductUser:User
    {
        public string Description { get; set; }
        public virtual Product Product { get; set; }         
    }
}
