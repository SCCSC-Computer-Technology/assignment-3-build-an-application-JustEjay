using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StateClassLibary
{
    public class ErrorMessage
    {
       
        public string inValidData(string dataType)
        {
            return $"You have entered invalid data type for {dataType}";
        }
        
        public string noRow()
        {
            return $"Row has not been selected";
        }
     
        public string noEntry()
        {
            return $"You have not selected a column";
        }
       
    }

    
}
