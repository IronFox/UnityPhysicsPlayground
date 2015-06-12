using UnityEngine;
using System.Collections;

public class MountVehicle : MonoBehaviour {


    public VehicleLogic vehicle;

    bool mounted = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        

        if (!mounted && Vector3.Distance(vehicle.transform.position, transform.position) < 5f)
        {
            mounted = true;
            GetComponent<MoveCharacter>().enabled = false;
        }

        if (mounted)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                mounted = false;
                GetComponent<MoveCharacter>().enabled = true;
                transform.position = transform.position * 0.6f;
            }
            else
            {

                float steer = 0f, accel = 0f;
                if (Input.GetKey(KeyCode.D))
                {
                    steer++;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    steer--;
                }

                if (Input.GetKey(KeyCode.W))
                {
                    accel++;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    accel--;
                }

                vehicle.steer = steer;
                vehicle.accel = accel;



                transform.position = vehicle.transform.position + vehicle.transform.up * 2f;
            }
            Camera.main.GetComponent<RotateCamera>().center = transform.position;
        }
	}
}
