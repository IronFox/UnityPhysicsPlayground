using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 speed = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            speed += Camera.main.transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            speed -= Camera.main.transform.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            speed += Camera.main.transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed -= Camera.main.transform.forward;
        }
        speed.y = 0f;
        speed.Normalize();
        if (Input.GetKey(KeyCode.LeftShift))
            speed *= 2f;

        this.GetComponent<CharacterController>().SimpleMove(speed*10f);
        Camera.main.GetComponent<RotateCamera>().center = transform.position;
	}
}
