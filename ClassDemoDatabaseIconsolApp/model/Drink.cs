using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDatabaseIconsolApp.model
{
    public class Drink
    {
        public int Id { get; set; }
        public String  Name { get; set; }
        public bool Alk { get; set; }

        public Drink(int id, string name, bool alk)
        {
            Id = id;
            Name = name;
            Alk = alk;
        }

        public Drink():this(-1,"dummy",false)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Alk)}={Alk.ToString()}}}";
        }
    }
}
