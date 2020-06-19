using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject planet;

    private void Awake()
    {
        int number = DataStore.planetNum;
        float radius = GetComponent<SphereCollider>().radius * 0.7f;

        for(int i=0; i<number; i++)
        {
            Vector3 position = Random.insideUnitSphere * radius;
            float mass = Random.Range(DataStore.min,DataStore.max);

            GameObject p = Instantiate(planet, position, Quaternion.identity);
            p.GetComponent<Rigidbody>().mass = mass;
        }
    }
}
