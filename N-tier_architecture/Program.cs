using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_tier_architecture
{
    class Program
    {
        static void Main(string[] args)
        {// UI: User Interface
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            int AddValue = BLL.SaveData(1, "Mehmet Hasbi", "KAYNAK");
            if (AddValue>0)
            {
                Console.WriteLine("Your data saved successfully");
            }
            else
            {
                Console.WriteLine("During the saving process, occurred a problem");
            }
            Console.ReadKey();
        }
    }
}
