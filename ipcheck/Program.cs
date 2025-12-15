// Check if network is available and dox yourself if it is
if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
{
    System.Console.WriteLine("Current IP Addresses for this container:");

    var hostname = System.Net.Dns.GetHostName();
    System.Console.WriteLine(hostname);
    System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(hostname);

    foreach(System.Net.IPAddress address in host.AddressList)
    {
        System.Console.WriteLine($"\t{address}");
    }
}
else
{
    System.Console.WriteLine("No Network Connection");
}