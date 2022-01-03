using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    /*
     * A delegate holds a reference to a method and
     * also to the target object on which the method should be called
     * C# delegates are type safe.
     * You can pass methods as parameters to a delegate to allow the delegate to point to the method.
     * Delegates are used to define call back methods and implement event handling
     */

    class DBConnection
    {
        public string name { get; set; }
        public DBConnection(string name)
        {
            this.name = name;
        }
    }
    class DBManager
    {
        static DBConnection[] activeConnections;
        public void AddConnections()
        {
            activeConnections = new DBConnection[5];
            for (int i = 0; i < 5; i++)
            {
                activeConnections[i] = new DBConnection("DBConnection" + (i + 1));
            }
        }
        public delegate void EnumConnectionsCallback(DBConnection connection);
        public static void EnumConnections(EnumConnectionsCallback callback)
        {
            foreach (DBConnection connection in activeConnections)
            {
                callback(connection);
            }
        }
    }
    class Program
    {
        public static void ActiveConnectionsCallback(DBConnection connection)
        {
            Console.WriteLine("callback method called for " + connection.name);
        }

        public static void Main(string[] args)
        {
            DBManager dbMgr = new DBManager();
            dbMgr.AddConnections();
            DBManager.EnumConnectionsCallback mycallback = new DBManager.EnumConnectionsCallback(ActiveConnectionsCallback);
            DBManager.EnumConnections(mycallback);

            Console.ReadKey();
        }

    }
}
