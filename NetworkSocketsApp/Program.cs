using System.Net.Sockets;

using (Socket socketTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
{
    try
    {
        socketTcp.Shutdown(SocketShutdown.Both);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally { socketTcp.Close(); }
}

Socket socketUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

