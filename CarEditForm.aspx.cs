using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoBase.Model;
using NHibernate;
using NHibernate.Cfg;

namespace MyWeb
{
    public partial class CarEditForm : System.Web.UI.Page
    {
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        protected void Page_Load(object sender, EventArgs e)
        {
            mySessionFactory = AutoBase.DBService.Factory;
            mySession = mySessionFactory.OpenSession();
        }
        private void Add(Entity Object)
        {
            using (mySession.BeginTransaction())
            {
                mySession.SaveOrUpdate(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }
        protected int id //...?id=Значение, возвращает из адресной строки
        {
            get
            {
                string val = this.Request.QueryString["id"];
                int i = Convert.ToInt32(val);
                return i;
            }
        }
        protected void CarListButton_Click(object sender, EventArgs e)
        {
            using (mySession.BeginTransaction())
            {
                ICriteria myCriteria = mySession.CreateCriteria<Car>();
                IList<Car> list = myCriteria.List<Car>();
                mySession.Transaction.Commit();
                mySession.Flush();
                int k = 0;
                for (int i=0; i<list.Count; i++)
                {
                    if (list[i].Id == id)
                    {
                        k = i;
                    };
                }
                CarNumber.Text = list[k].Number;
                CarMark.Text = list[k].Mark;
                CarModel.Text = list[k].Model;
                CarBodyType.Text = list[k].BodyType;
                CarColor.Text = list[k].Color;
                EngineName.Text = list[k].idEngine.Name;
                EngineVolume.Text = list[k].idEngine.Volume;
                EngineTorque.Text = list[k].idEngine.Torque;
                EnginePower.Text = list[k].idEngine.Power;
                EngineId.Text = Convert.ToString(list[k].idEngine.Id);
            }
        }
        protected void CarSendButton_Click(object sender, EventArgs e)
        {
            AutoBase.Model.Engine SendingEngine = new AutoBase.Model.Engine { Id = Convert.ToInt32(EngineId.Text), Name = EngineName.Text, Volume = EngineVolume.Text, Torque = EngineTorque.Text, Power = EnginePower.Text };
            Add(SendingEngine);
            AutoBase.Model.Car SendingCar = new AutoBase.Model.Car { Id = id, Number = CarNumber.Text, Mark = CarMark.Text, Model = CarModel.Text, BodyType = CarBodyType.Text, Color = CarColor.Text, idEngine = SendingEngine };
            Add(SendingCar);
        }
    }
}