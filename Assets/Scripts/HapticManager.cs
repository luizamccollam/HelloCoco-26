using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.PXR;

public class HapticManager : MonoBehaviour
{
    private static HapticManager _instance;
    public static HapticManager instance
    {
        get => _instance;
        private set
        {
            if (_instance != null)
                Debug.LogWarning("Second attemp to get FullHapticManager");
            _instance = value;
        }
    }

    // 1.0f max strength of haptics
    public float lowAmp = .2f;
    public float medAmp = .6f;
    public float highAmp = 1.0f;


    // max freq is 500
    public int lowFreq = 100;
    public int medFreq = 350;
    public float highFreq = 1.0f;

    // Duration is in ms
    public int durationSec = 1000;
    private int oneSec = 1000;
    private int maxTime = 65535;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Controller, Amp strenght 0-1, Duration in ms, freq 0-500
    public void RightHapticMed()
    {
        PXR_Input.SendHapticImpulse(PXR_Input.VibrateType.RightController, medAmp, oneSec, medFreq);
    }

    public void LeftHapticMed()
    {
        PXR_Input.SendHapticImpulse(PXR_Input.VibrateType.LeftController, medAmp, durationSec, medFreq);
    }

    public void StopHatics()
    {
        PXR_Input.SendHapticImpulse(PXR_Input.VibrateType.LeftController, 0, 0, medFreq);
        PXR_Input.SendHapticImpulse(PXR_Input.VibrateType.RightController, 0, 0, medFreq);
    }
}
