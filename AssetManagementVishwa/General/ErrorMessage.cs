using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementVishwa.General
{
    internal class ErrorMessage
    {
        internal ConcurrentDictionary<string, string> Errors;

        internal ErrorMessage() { 
        
            Errors = new ConcurrentDictionary<string, string>();

            //Error
            Errors.TryAdd("db_error", "Unable to Connect Database Server.");
            Errors.TryAdd("invalid_id", "Invalid User ID.");
            Errors.TryAdd("invalid_password", "Inavalid User Password.");
            Errors.TryAdd("not_reachable", "DataBase Server is not reachable");
        
        }
    }
}
