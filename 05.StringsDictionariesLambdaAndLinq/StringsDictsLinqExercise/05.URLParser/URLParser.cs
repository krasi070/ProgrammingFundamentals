namespace _05.URLParser
{
    using System;

    public class URLParser
    {
        public static void Main()
        {
            string url = Console.ReadLine();
            string protocol = string.Empty;
            string server = string.Empty;
            string resources = string.Empty;
            int indexOfProtocolEnd = url.IndexOf("://");
            if (indexOfProtocolEnd != -1)
            {
                protocol = url.Substring(0, indexOfProtocolEnd);
                int indexOfResources = url.Substring(indexOfProtocolEnd + 3).IndexOf("/");
                if (indexOfResources != -1)
                {
                    server = url.Substring(indexOfProtocolEnd + 3, indexOfResources);
                    resources = url.Substring(indexOfResources + 4 + indexOfProtocolEnd);
                }
                else
                {
                    server = url.Substring(indexOfProtocolEnd + 3);
                }
            }
            else
            {
                int indexOfResources = url.IndexOf("/");
                if (indexOfResources != -1)
                {
                    server = url.Substring(0, indexOfResources);
                    resources = url.Substring(indexOfResources + 1);
                }
                else
                {
                    server = url;
                }
            }

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resources);
        }
    }
}