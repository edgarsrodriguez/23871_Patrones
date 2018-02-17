using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _180209_Practica5.Classes
{
    public class PostalServiceData : Observable
    {
        public PostalServiceData(int time)
        {
            TimerCallback cb = new TimerCallback(TimerTask);
            Timer timerDHL = new Timer(cb, this, time, time);
        }
        public string Name { get; set; }
        //public int Time { get; set; }
        public string Msg { get; set; }
        
        public void sendInfo(object obj)
        {
            setChanged();
            notify(obj);
            clearChanged();
        }

        static void TimerTask(object obj)
        {
            PostalServiceData provider = (PostalServiceData)obj;
            provider.sendInfo("Notificacion de " + provider.Name + "\nFecha: " + DateTime.Now + "\nMensaje: " + provider.Msg + "\n");
        }
    }
}
