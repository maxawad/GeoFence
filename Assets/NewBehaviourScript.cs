using UnityEngine;
using System.IO.Ports;


public class ArduinoRelayControl : MonoBehaviour
{
    SerialPort serialPort;
    string portName = "/dev/tty.usbmodem2101"; // Adjust this to match your Arduino's port
        int baudRate = 9600;
    bool isConnected = false;

    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);
        Debug.Log("Started successfully");
        try
        {
            serialPort.Open();
            Debug.Log("Port opened successfully");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error opening serial port: " + e.Message);
        }
    }

    void Update()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            try
            {
                if (!isConnected)
                {
                    string data = serialPort.ReadLine().Trim();
                    if (data == "Connected")
                    {
                        isConnected = true;
                        Debug.Log("Arduino Connected");
                    }
                }
                else
                {
                    string data = serialPort.ReadLine();
                    if (data == "1")
                    {
                        Debug.Log("Turning on the virtual relay.");
                    }
                    else if (data == "0")
                    {
                        Debug.Log("Turning off the virtual relay.");
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.LogWarning("Error reading from serial port: " + e.Message);
            }
        }
    }

    void OnDestroy()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
            Debug.Log("Port closed");
        }
    }
}