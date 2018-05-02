using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uncivilized.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int NationId { get; set; }
        public string Name { get; set; }
        public string Government { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public int Happiness { get; set; }
        public int Capital { get; set; }
        public int Resources { get; set; }
        public virtual User User { get; set; }

        public void SetProperties()
        {
            if( this.Region == "desert")
            {
                this.Capital = 3;
            }
            else
            {
                this.Capital = 2;
            }

            this.Population = 3;
            this.Resources = 3;
            this.Happiness = (3 * 3) / 3;
        }

        public void UpdatePropeties()
        {

        }
    }

    
    //int getCapital(int capital)
    //{

    //    switch (nation.Government)
    //    {
    //        case "":
    //            break;

    //    }

    //    return capital;
    //}


    //switch (nation.Government)
    //{
    //    case "democracy":
    //        this.Capital = getCapital(1);
    //        this.Population = getPopulation();
    //        nation.Resources = nation.getResources();

    //        break;
    //    case "dictatorship":
    //        Console.WriteLine("Case 2");
    //        break;
    //    case "monarchy":
    //        Console.WriteLine("Case 1");
    //        break;
    //    case "parliment":
    //        Console.WriteLine("Case 2");
    //        break;
    //    case "socialism":
    //        Console.WriteLine("Case 1");
    //        break;
    //    case "theocracy":
    //        Console.WriteLine("Case 2");
    //        break;

    //    default:
    //        // This will default to rule by the lizard people
    //        break;
    //}




}
