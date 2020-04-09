using System;
using System.ComponentModel;

namespace Project.DAL.Model
{
    public abstract class BaseClass : IDataErrorInfo
    {
        public abstract string this[string columnName] { get; }
        

        public bool IsValid()
        {       //AFWERKEN
            return string.IsNullOrWhiteSpace(Error);
        }

        public string Error
        {
            get
            {
                string foutmeldingen = "";
                foreach (var item in this.GetType().GetProperties())
                { //reflection 
                    if (item.CanRead)
                    {
                        string fout = this[item.Name];
                        if (!string.IsNullOrWhiteSpace(fout))
                        {
                            foutmeldingen += fout + Environment.NewLine;
                        }
                    }
                }
                return foutmeldingen;
            }
        }
    }
    public class eee { }
}