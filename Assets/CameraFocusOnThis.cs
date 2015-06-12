using UnityEngine;
using System.Collections;

public class CameraFocusOnThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.GetComponent<RotateCamera>().center = transform.position;
	
	}
}
