using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice6
{
    // Опис делегату
    delegate void MyEventHandler();

    internal class EventNotifier
    {
        // Широкомовний івент для виявлення нового замовлення
        public event EventHandler<EventArgs> NewOrderEvent;
        // Клас, який ініціалізує подію
        public event MyEventHandler Activate;

        public void TriggerEvent()
        {
            Activate?.Invoke();
        }
        public void TriggerNewOrderEvent()
        {
            NewOrderEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
