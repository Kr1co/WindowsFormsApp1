using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UsersClasses
{
    public class StringPair
    {
        public StringPair(string emailAdress, string name)
        {
            EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
            emailAdress;

            Name = String.IsNullOrWhiteSpace(name) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
                name;
        }
        public string EmailAdress { get; set;}
        public string Name { get; set;}
    }
}
