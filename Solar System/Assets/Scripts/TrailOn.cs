using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrailOn : MonoBehaviour
{
    TrailRenderer[] trails;
    static bool on;

    public Toggle t;

    private void Start()
    {
        trails = FindObjectsOfType<TrailRenderer>();
        t.isOn = on;

    }
    public void trail(Toggle toggle)
    {
        on = toggle.isOn;
        foreach (TrailRenderer _trail in trails)
        {
            _trail.enabled = on;
        }
    }
}
