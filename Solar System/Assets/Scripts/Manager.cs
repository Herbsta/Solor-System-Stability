using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public FreeFlyCamera camera;
    public Image skip;
    float time;

    static Vector3 pos = new Vector3(725,771,816);
    static Vector3 rot = new Vector3(35,221,0);

    public static bool play = true;

    private void Start()
    {
        time = Time.time;
        DataStore.total += 1;

    }

    private void Awake()
    {

        if(pos != null)
        {
            Camera.main.transform.position = pos;
            Quaternion nrot = new Quaternion();
            nrot.eulerAngles = rot;
            Camera.main.transform.rotation =nrot;
        }

        if(DataStore.total >= DataStore.limit)
        {

            SceneManager.LoadScene(0);
        }

        Body.Bodies = null;


    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene(0);

        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(1);
        }


        if (Input.GetButtonDown("Jump"))
        {
            play = !play;

        }

        if (play)
        {
            skip.color = Color.green;
        }
        else
        {
            skip.color = Color.red;
        }

        if (Time.time > time + (float) DataStore.sucessTime && play)
        {
            Debug.Log("Success");
            saveCam();
            DataStore.sucess += 1;
            SceneManager.LoadScene(1);
        }

    }

    public static void saveCam()
    {
        pos = Camera.main.transform.position;
        rot = Camera.main.transform.rotation.eulerAngles;
    }

}
