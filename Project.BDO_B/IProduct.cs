namespace Project.DAL.Model
{
    public interface IProduct
    {   // Interface = class contract
        string Name { get; set; }
        string Version { get; set; }
        string Description { get; set; }
        Vendor Vendor { get; set; }
        bool IsActive { get; set; }
    }
}
