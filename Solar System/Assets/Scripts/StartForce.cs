using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StartForce : MonoBehaviour {

	Vector3 force;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		GameObject sun = GameObject.FindGameObjectWithTag("Player");
		float d = Vector3.Distance (transform.position, sun.transform.position);

		float escapeV = Mathf.Pow(2*Body.GRAVITY_CONST * sun.GetComponent<Rigidbody>().mass / d,0.5f);
		escapeV /= 10f;


		float v = Random.Range(escapeV * (DataStore.minV/100f) , escapeV * (DataStore.maxV / 100f));

		force = new Vector3(0,Random.Range(-1f,1f), Random.Range(-1f, 1f)).normalized * v;

		rb.AddForce (force, ForceMode.VelocityChange);
	}
	
}
