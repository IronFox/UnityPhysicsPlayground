using UnityEngine;
using System.Collections;

public class PlaceWheel : MonoBehaviour {

    public float steerFactor = 0f;
    public float accelFactor = 0f;
    Transform wheel;
    WheelCollider collider;
    VehicleLogic owner;

    float rotationAt = 0f;
	// Use this for initialization
	void Start () {
        collider = GetComponent<WheelCollider>();
        owner = GetComponentInParent<VehicleLogic>();
        foreach (Transform t in transform)
            wheel = t;  //happens only once
	}


    public float t;

	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        float at = collider.suspensionDistance + collider.radius;
        if (Physics.Raycast(new Ray(transform.position + transform.TransformVector(collider.center), -transform.up), out hit, at))
        {
            at = hit.distance + collider.radius;
        }

        t = collider.steerAngle = 25f * steerFactor * owner.steer;


        rotationAt += Time.deltaTime * collider.rpm / 60f * 360f * accelFactor;
        //rotationAt = Mathf.Repeat(rotationAt, 360f);

        wheel.localPosition = new Vector3(0, -(at - 2f * collider.radius), 0) + collider.center;
        wheel.localRotation = Quaternion.Euler(rotationAt, collider.steerAngle, -90);

        collider.motorTorque = -5f * owner.accel;
        if (Input.GetKey(KeyCode.LeftShift))
            collider.motorTorque *= 3f;
        collider.brakeTorque = 0f;

        this.GetComponent<LineRenderer>().SetPosition(0, wheel.position);
        this.GetComponent<LineRenderer>().SetPosition(1, collider.transform.position);
	    
	}
}
