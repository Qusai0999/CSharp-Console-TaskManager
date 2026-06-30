using System;

namespace TaskManager.services
{
    public class CommandService
    {
        /* Responsible of parsing commands  */
        public static (string Verb, string Payload ) Parse(string input)
        {
            if (string.IsNullOrEmpty(input)){return ("empty","");}
            
            var parts = input.Trim().Split(' ', 2);
            var verb = parts[0];
            var payload = parts[1];

            return (verb, payload);
        }
    }
}
