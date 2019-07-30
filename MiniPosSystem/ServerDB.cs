using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Contains helper methods for manipulating the servers table
    /// </summary>
    static class ServerDB
    {
        public static List<Servers> GetServers()
        {
            using (var context = new OurRestaurantModel())
            {
                List<Servers> servers = context.Servers.ToList();

                return servers;
            }
        }

        /// <summary>
        /// Adds new server to database
        /// </summary>
        /// <param name="newServer"></param>
        /// <returns></returns>
        public static Servers AddServer(Servers newServer)
        {
            using (var context = new OurRestaurantModel())
            {
                context.Servers.Add(newServer);
                context.SaveChanges();

                return newServer;
            }
        }
    }
}
