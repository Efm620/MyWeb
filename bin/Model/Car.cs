using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model
{
    public class Car : Entity
    {
        private string number;
        public virtual string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string color;
        public virtual string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string bodyType;
        public virtual string BodyType
        {
            get { return bodyType; }
            set { bodyType = value; }
        }
        private string mark;
        public virtual string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        private string model;
        public virtual string Model
        {
            get { return model; }
            set { model = value; }
        }
        private Engine IdEngine;
        public virtual Engine idEngine
        {
            get { return IdEngine; }
            set { IdEngine = value; }
        }

    }
}
