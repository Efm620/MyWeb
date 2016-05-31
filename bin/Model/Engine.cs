using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model
{
    public class Engine: Entity
    {
        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string volume;
        public virtual string Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private string torque;
        public virtual string Torque
        {
            get { return torque; }
            set { torque = value; }
        }
        private string power;
        public virtual string Power
        {
            get { return power; }
            set { power = value; }
        }
        private ISet<Car> cars = new HashSet<Car>();
        public virtual ISet<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
    }
}
