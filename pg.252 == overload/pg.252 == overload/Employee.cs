using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._252____overload
{
    
    public class Employee 
    {
        public int id = 1;
        public static bool operator ==(Employee staff, Employee staff1)
        {
            return staff.id == staff1.id;
        }
        public static bool operator !=(Employee staff, Employee staff1)
        {
            return staff.id == staff1.id;
        }
        public override bool Equals(object obj)
        {
            return id.Equals(obj);
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
