using UnityEngine;
using System.Collections;

public class Push : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        bool trigger = Input.GetKey(KeyCode.Space);

       	if (!trigger && Input.GetMouseButton(0))
        {
		    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
		    if (GetComponent<Collider>().Raycast(ray, out hit, float.MaxValue))
            {
			    //markerObject.position = ray.GetPoint(rayDistance);
                trigger = true;
		    }
	    }



        GetComponent<ConstantForce>().force = new Vector3(trigger ? 3f : 0f, 0f, 0f) * (Input.GetKey(KeyCode.LeftControl) ? 5f : 1f);

        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, transform.position + GetComponent<ConstantForce>().force*10f);
	}
}
