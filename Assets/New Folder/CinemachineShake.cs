using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineShake : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin;
    private bool FlipFlop = false;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnGUI()
    {
        if (GUILayout.Button("Shake"))
        {
            cinemachineVirtualCamera = GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();
            if (cinemachineVirtualCamera != null)
            {
                cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                if (FlipFlop)
                {
                    cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0;
                }
                else
                {
                    cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 1;

                }
            }
            FlipFlop = !FlipFlop;
        }
    }

}
