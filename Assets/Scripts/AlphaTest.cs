using UnityEngine;
using OpenBCI.Network.Streams; // make sure you import the right thing from the OpenBCI SDK package

public class AlphaTest : MonoBehaviour
{
    public GameObject pillar;  // make sure you have a GameObject in the scene to represent the pillar
    [SerializeField] private AverageBandPowerStream Stream; // attach the AverageBandPowerStream from the Unity prefab
    [SerializeField] private PPGMetricsStream HeartRateStream; // attach the HeartRateStream from the Unity prefab
    [SerializeField] private EMGStream FaceStream;
    private float pillarHeight;
    float currentRatio = 0;
    float previousRatio = 0;
    float changeThreshold = 0.3f;
    int frames = 0;
    // Start is called once before the first frame update
    void Start()
    {
        pillarHeight = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // log the alpha band power value to the unity console
        //if statement for console logs to happen every 100 frames
        if (frames % 60 == 0)
        {
            // Debug.Log("Alpha: " + Stream.AverageBandPower.Alpha);
            // Debug.Log("Beta: " + Stream.AverageBandPower.Beta);
            //print out all of heart rate data
            for (int i = 0; i < HeartRateStream.GetHeartRateData().Length; i++)
            {
                Debug.Log("Heart Rate: " + HeartRateStream.GetHeartRateData()[i]);
            }
            //Debug.Log("Heart Rate: " + HeartRateStream.GetHeartRateData()[0]);
            frames = 0;

        }
       
        // float alpha = Stream.AverageBandPower.Alpha;
        // float beta = Stream.AverageBandPower.Beta;

        // // Debug.Log("Alpha: " + Stream.AverageBandPower.Alpha); //make alpha focus thresholds
        // // Debug.Log("Beta: " + Stream.AverageBandPower.Beta); //make beta stress thresholds
        // Debug.Log("Heart Rate: " + HeartRateStream.GetHeartRateData()[0]);

        //  if (beta != 0f) // Avoid division by zero
        // {
        //     currentRatio = alpha / beta;
        // }
        // else
        // {
        //     currentRatio = Mathf.Infinity; // Or handle this case as needed
        // }

        // // Check if the ratio has changed significantly
        // if (Mathf.Abs(currentRatio - previousRatio) > changeThreshold)
        // {
        //     Debug.Log("Ratio has changed significantly");
        //     previousRatio = currentRatio; // Update previous ratio
        // }

        // for (int i = 0; i < FaceStream.Channels.Length; i++)
        // {
        //     Debug.Log("EMG Channel " + i + ": " + FaceStream.Channels[i]);
        // }

        // // scale the cylinder height based on the alpha band power
        // pillarHeight = Stream.AverageBandPower.Alpha;
        // pillar.transform.localScale = new Vector3(1, pillarHeight, 1); 
    }

    
}