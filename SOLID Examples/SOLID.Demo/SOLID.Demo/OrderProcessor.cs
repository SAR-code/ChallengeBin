using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo
{
    // EXAMPLE OF SINGLE RESPONSIBILITY PRINCIPLE
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }
        public void Process() // Calls SRP individual methods
        {
            orderValidator.Validate();
            foreach (var item in orderSaver)
            {
                item.Save(null);
            }
            orderNotificationSender.SendNotification();
        }
        
    }

    public class  OrderValidator
    {
        public void Validate() { }
    }

    public interface IOrderSaver //OCP
    {
        void Save(string order);
    }

    public interface IOrderDeleter
    {
        void Delete(int id);
    }

    public interface IOrderReader
    {
        string Read(int id);
    }

    public class DbOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }

    public class CacheOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }

    public class OrderNotificationSender
    {
        public void SendNotification() { }
    }
}
