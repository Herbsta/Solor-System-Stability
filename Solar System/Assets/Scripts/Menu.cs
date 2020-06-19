using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject warning;
    public TMP_Text succes;
    public TMP_Text total;
    public TMP_Text minimumV;
    public TMP_Text maxmimumV;
    public TMP_Text minMass;
    public TMP_Text maxMass;
    public TMP_Text planetNum;
    public TMP_Text totalTest;
    public TMP_Text _successTime;
     private void Awake()
    {
        succes.text = DataStore.sucess.ToString();
        total.text = DataStore.total.ToString();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;




    }

    private void Start()
    {
        DataStore.total = 0;
        DataStore.sucess = 0;

        totalTest.text = DataStore.total.ToString();
        minimumV.text = DataStore.minV.ToString();
        maxmimumV.text = DataStore.maxV.ToString();
        minMass.text = DataStore.min.ToString();
        maxMass.text = DataStore.max.ToString();
        planetNum.text = DataStore.planetNum.ToString();
        _successTime.text = DataStore.sucessTime.ToString();
    }
    public void begin()
    {
        if(DataStore.sucessTime != 0 && DataStore.min != 0 && DataStore.max != 0 && DataStore.planetNum != 0 && DataStore.limit !=0 && DataStore.minV != 0 && DataStore.maxV != 0)
        {
            SceneManager.LoadScene(1);

        }
        else
        {
            warning.SetActive(true);
        }
    }

    public void end() {
        Application.Quit();
    }

    public void max(TMP_InputField text)
    {
        if (text.text != "")
        {
            DataStore.max = int.Parse(text.text);
        }
    }

    public void min(TMP_InputField text)
    {
        if(text.text != "")
        {
            DataStore.min = int.Parse(text.text);

        }
    }

    public void num(TMP_InputField text)
    {
        if (text.text != "")
        { 
        DataStore.planetNum = Convert.ToInt32(text.text);
        }
    }

    public void testNum(TMP_InputField text)
    {
        if (text.text != "")
        {
            DataStore.limit = Convert.ToInt32(text.text);
        }
    }

    public void minV(TMP_InputField text)
    {
        if(text.text != "")
        {
            DataStore.minV = float.Parse(text.text);
        }
    }

    public void maxV(TMP_InputField text)
    {
        if (text.text != "")
        {
            DataStore.maxV = float.Parse(text.text);
        }
    }

    public void successTime(TMP_InputField text)
    {
        if(text.text != "")
        {
            DataStore.sucessTime = int.Parse(text.text);
        }
    }

}
