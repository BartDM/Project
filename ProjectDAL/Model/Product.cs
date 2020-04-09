using System.Collections.Generic;

namespace Project.DAL.Model
{
    public class Product : BaseClass, IProduct
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Name" && string.IsNullOrWhiteSpace(Name))
                {
                    return "Name should not be empty.";
                }
                else if (columnName == "Description" && string.IsNullOrWhiteSpace(Description))
                {
                    return "Description should not be empty.";
                }

                return "";
            }
        }

        //public abstract string Error { get; }

        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        //navigation properties
        //DB 1-on-1 relationship
        public virtual Vendor Vendor { get; set; }
        //DB 1-on-many relationship
        public virtual List<User> Users { get; set; }




        //Basic methodes
        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null &&
                   Name == product.Name &&
                   Version == product.Version;
        }

        public override int GetHashCode()
        {
            var hashCode = 2112831277;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Version);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
