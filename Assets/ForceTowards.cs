using UnityEngine;
using System.Collections;

public class ForceTowards : MonoBehaviour {

    public Transform target;
    public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
            GetComponent<ConstantForce>().force = (target.position - transform.position) * force;


	}
}
