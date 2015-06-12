using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Vector3 center = new Vector3(0, -30, 0);
    public float radius = 70f;
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 euler = Vector3.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            euler.y += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            euler.y -= 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            euler.x -= 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            euler.x += 1;
        }

        Vector3 current = transform.eulerAngles;

        if (Input.GetKey(KeyCode.PageDown))
            radius *= Mathf.Pow(4f, Time.deltaTime);
        if (Input.GetKey(KeyCode.PageUp))
            radius *= Mathf.Pow(4f, -Time.deltaTime);



        current += euler * 180f * Time.deltaTime;
        current.x = Mathf.Clamp(current.x, 10f, 80f);

        transform.rotation = Quaternion.Euler(current);
        transform.position = center - transform.forward * radius;
    }
}
