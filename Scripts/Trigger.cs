using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] ParticleSystem parts = null;
    public int band;
    public float threshold;
    private void Update()
    {
        if (AudioAnalysis._freqBands[band] > threshold)
        {
            playParts();
        }
    }

    public void playParts()
    {
        parts.Play();
    }
}