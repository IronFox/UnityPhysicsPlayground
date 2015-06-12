using UnityEngine;
using System.Collections;

public class ShootAtThis : MonoBehaviour {


    public Transform shootObject;
//    public Camera origin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && shootObject != null)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if (GetComponent<Collider>().Raycast(ray, out hit, float.MaxValue))
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                //markerObject.position = ray.GetPoint(rayDistance);

                shootObject.GetComponent<Rigidbody>().velocity = ray.direction * 40f;
                shootObject.transform.position = Camera.main.transform.position + ray.direction * 1f;


                //Vector3 d = hit.point - transform.position;
                //Vector3 force = -d.normalized * 10000f;
                //GetComponent<Rigidbody>().AddForce(force);
            }


        }


	}
}
