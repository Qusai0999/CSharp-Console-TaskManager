using System;

namespace TaskManager.services
{
    public class CommandService
    {
        /* Responsible of parsing commands  */
        public static (string? Verb, string? Payload ) Parse(string? input)
        {
            if (string.IsNullOrEmpty(input)){return ("empty","");}
            
            var parts = input.Trim().Split(' ', 2);
            var verb = parts[0].ToLower().Trim();
            string?  payload = parts.ElementAtOrDefault(1); // out of range exception on one command !!!
            if (string.IsNullOrEmpty(payload)){payload = " " ;}
            return (verb, payload);
        }
    }
}
