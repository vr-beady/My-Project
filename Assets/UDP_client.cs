using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UDP_client : MonoBehaviour
{
    // 
    private string serverIP = "172.20.10.3";
    private int serverPort = 5000;

    private UdpClient udpClient;

    private void Start()
    {
        udpClient = new UdpClient();

        // 
        IPAddress ipAddress = IPAddress.Parse(serverIP);
        IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, serverPort);

        // 
        string message = "Hello worldOKKKKK";

        byte[] data = Encoding.UTF8.GetBytes(message);

        // 
        udpClient.Send(data, data.Length, remoteEndPoint);

        Debug.Log($"¤w°e®ø®§¨ì {serverIP}:{serverPort}: {message}");
    }

    private void OnDestroy()
    {
        // 
        if (udpClient != null)
        {
            udpClient.Close();
        }
    }
}
