// testing serial communication w Arduino (microcontroller) and Unity (Varjo PCVR)

using UnityEngine;
using System.IO.Ports;
using System.Collections;
using OpenBCI.Network.Streams;
using UnityEngine.UI;


public class ArduinoSerial : MonoBehaviour
{
	public string portName = "COM6";  
	public int baudRate = 460800;    
    [SerializeField] private EMGStream EMG;
    [SerializeField] private PPGMetricsStream PPG;
    [SerializeField] private AverageBandPowerStream BandPower;

    public GameObject uiCanvas;
    public GameObject orange;
    public GameObject lavender;



	private SerialPort serialPort;

    float UserHighestAlpha = 0;

    float ave = 0;
    float heart = 0;
    float changeThresholdEMG = 0.6f;
    int frames = 0; 
    bool scent_2_triggered = false;
    bool scent_1_triggered = false;
    bool tracking = true;


	void Start()
	{
    	// Create and open the serial port
    	serialPort = new SerialPort(portName, baudRate);
    	serialPort.ReadTimeout = 500;  
    	serialPort.Open();

    	if (serialPort.IsOpen)
    	{
        	Debug.Log("Serial port opened successfully");
    	}
    	else
    	{
        	Debug.LogError("Failed to open serial port");
    	}

        StartCoroutine(TrackHighestValueOverTime());
	}
    IEnumerator TrackHighestValueOverTime()
    {
        // Set tracking to true for the first 10 seconds
        float timer = 0f;

        // Track the highest value for 10 seconds
        while (timer < 10f)
        {
            // Update the highest value if the current value is greater
            if (BandPower.AverageBandPower.Alpha > UserHighestAlpha)
            {
                UserHighestAlpha = BandPower.AverageBandPower.Alpha;
            }

            // Increment the timer
            timer += Time.deltaTime;

            // Yield return to continue the loop after the next frame
            yield return null;
        }

        // Stop tracking and print the highest value after 10 seconds
        tracking = false;
        uiCanvas.SetActive(false);
        Debug.Log("Highest Alpha in first 10 seconds: " + UserHighestAlpha);
    }

	void Update()
	{
    	// if (Input.GetKeyDown(KeyCode.Space))
    	// {
        // 	TriggerArduinoAction();
    	// }
   	 
    	if (Input.GetKeyDown(KeyCode.A))
    	{
        	ScentOne();
            lavender.SetActive(true);
    	}

    	else if (Input.GetKeyDown(KeyCode.S))
    	{
        	ScentTwo();
            orange.SetActive(true);
    	}

        if (frames % 60 == 0 && !scent_2_triggered && !tracking)
        {
            float[] data = EMG.Channels;
            ave = data[0]+data[1]+data[2]+data[3]+data[6]+data[7];
            ave = ave/6;
            // Debug.Log("EMG AVE: " + ave);
            if(ave >= changeThresholdEMG){
                ScentTwo(); //TODO: change to scent 2
                Debug.Log("EMG AVE: " + ave);
                scent_2_triggered = true;
                orange.SetActive(true);
            }
        }
        if (frames % 60 == 0 && !scent_1_triggered && !tracking)
        {
            float alpha = BandPower.AverageBandPower.Alpha;
          
            // Debug.Log("Alpha: " + alpha);
            if(alpha <= UserHighestAlpha*0.55){ //if alpha level drops by a third
                ScentOne();
                Debug.Log("Alpha: " + alpha);
                scent_1_triggered = true;
                lavender.SetActive(true);
            }
        }
        if (frames % 60 == 0 && !scent_1_triggered && !tracking && PPG.GetHeartRateData()[0]!=0) //about three seconds
        {
            float[] data2 = PPG.GetHeartRateData(); //TODO: check if reading data like this is correct
            Debug.Log("PPG AVE: " + data2[0] + " " + data2[4]);
            if (data2[4] - data2[0] > 5){ //if bpm jumps by 5 in 3 seconds
               ScentOne(); 
                Debug.Log("PPG triggered: " + data2[0] + " " + data2[4]);
                scent_1_triggered = true;
                lavender.SetActive(true);
            }
        }
        frames++;
	}


/*
	public void TriggerArduinoAction()
	{
    	if (serialPort != null && serialPort.IsOpen)
    	{
        	serialPort.WriteLine("FAN");
        	Debug.Log("Sent: FAN to ESP32");
    	}
	}
*/

	public void ScentOne()
	{
    	if (serialPort != null && serialPort.IsOpen)
    	{
        	serialPort.WriteLine("ScentOne");
        	Debug.Log("Sent: ScentOne to ESP32");
    	}
	}

	public void ScentTwo()
	{
    	if (serialPort != null && serialPort.IsOpen)
    	{
        	serialPort.WriteLine("ScentTwo");
        	Debug.Log("Sent: ScentTwo to ESP32");
    	}
	}

	void OnDestroy()
	{
    	if (serialPort != null && serialPort.IsOpen)
    	{
        	serialPort.Close();
        	Debug.Log("Serial port closed");
    	}
	}
}



