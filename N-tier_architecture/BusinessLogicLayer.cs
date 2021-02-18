using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_tier_architecture
{
   internal class BusinessLogicLayer
    {
        DataAccessLayer dal;
        public BusinessLogicLayer()
        {
            new DataAccessLayer();
        }

        internal int SaveData(int CostumerID, string Name, string Surname)
        {
            if (!string.IsNullOrEmpty(Name)&&!string.IsNullOrEmpty(Surname))
            {
                Costumer C1 = new Costumer();
                C1.ID = CostumerID;
                C1.Name = Name;
                C1.Surname = Surname;
               return  dal.SaveData(C1); // we cleaned up our codes and data now we can carry it up to the next tier 
            }
            else
            {
                return -1; // This is going to provide an missing parameter error.
            }
        }
    }
}
