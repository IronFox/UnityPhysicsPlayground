using UnityEngine;
using System.Collections;

public class LineToJointTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, GetComponentInParent<SpringJoint>().connectedBody.position);
	}
}
