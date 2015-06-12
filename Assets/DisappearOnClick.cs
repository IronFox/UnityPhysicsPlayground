using UnityEngine;
using System.Collections;

public class DisappearOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool trigger = false;

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
        if (trigger)
        {
            Destroy(gameObject);
        }

	}
}
