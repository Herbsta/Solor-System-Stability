using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crashintosun : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Manager.saveCam();
        SceneManager.LoadScene(1);
    }
}
