using UnityEngine;
using System.Collections;

public class JumpOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (GetComponent<Collider>().Raycast(ray, out hit, float.MaxValue))
            {
                //markerObject.position = ray.GetPoint(rayDistance);
                Vector3 d = hit.point - transform.position;
                Vector3 force = -d.normalized * 10000f;
                GetComponent<Rigidbody>().AddForce(force);
            }
        }
	}
}
