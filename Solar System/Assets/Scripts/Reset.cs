﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Manager.saveCam();
        SceneManager.LoadScene(1);
    }
}