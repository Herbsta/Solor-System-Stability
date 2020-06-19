using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Slider slider;
    public TMP_Text timescale;

    public static float timevar;

    private void Start()
    {
        timescale.text = Time.timeScale.ToString();
        slider.maxValue = Time.timeScale;
        timevar = Time.timeScale;

    }

    public void timeNumber(TMP_InputField text)
    {
        if(text.text != "")
        {
            int t = int.Parse(text.text);
            Time.timeScale = t;
            slider.maxValue = t;
            slider.value = t;
            timevar = t;
        }
    }

    public void timeslider()
    {
        Time.timeScale = slider.value;
        timevar = slider.value;
    }


}
