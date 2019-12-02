using System;

namespace Tavisca.Applause
{
    [Serializable]
    public class Info
    {
        
        public string Message { get; set; }

        public Info(string code, string message)
        {
            

            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException(nameof(message));

           
            Message = message;
        }

    }
}