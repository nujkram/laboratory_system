using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.components
{
    class Connection
    {
        public string conString = String.Format("datasource={0};username={1};password={2}",
            Values.server_address, Values.server_username, Values.server_password);
    }
}
