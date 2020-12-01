using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenList
{
    abstract class Citizen
    {
        public string Name { get; set; }
        public string Passport { get; set; }

        public static bool operator ==(Citizen firstCitizen, Citizen secondCitizen)
        {
            return firstCitizen.Name == secondCitizen.Name && firstCitizen.Passport == secondCitizen.Passport;
        }
        public static bool operator !=(Citizen firstCitizen, Citizen secondCitizen)
        {
            return !(firstCitizen == secondCitizen);
        }
    }
}
