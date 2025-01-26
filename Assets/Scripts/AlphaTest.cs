using UnityEngine;
using OpenBCI.Network.Streams;
using System.Data; // make sure you import the right thing from the OpenBCI SDK package

public class AlphaTest : MonoBehaviour
{
    public GameObject pillar;  // make sure you have a GameObject in the scene to represent the pillar
    [SerializeField] private EMGStream EMG; // attach the HeartRateStream from the Unity prefab
    private float pillarHeight;
    float sum = 0;
    float previousRatio = 0;
    float changeThresholdEMG = 0.7f;
    int frames = 0;
    // Start is called once before the first frame update


    void Start()
    {
        pillarHeight = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (frames % 220 == 0)
        {
            float[] data = EMG.Channels;
            sum = data[0]+data[1]+data[2]+data[3]+data[6]+data[7];
            sum = sum/6;
            // Debug.Log("EMG CH1 left cheek: " + data[0]);
            // Debug.Log("EMG CH2 right cheek: " + data[1]);
            // Debug.Log("EMG CH3 left eyebrow: " + data[2]);
            // Debug.Log("EMG CH4 right eyebrow: " + data[3]);
            // Debug.Log("EMG CH7 left forehead: " + data[6]);
            // Debug.Log("EMG CH8 right forehead: " + data[7]);
            Debug.Log("EMG AVE: " + sum);
            if(sum >= changeThresholdEMG){
                //trigger
            }

        }
        frames++;
       
    }

    
}