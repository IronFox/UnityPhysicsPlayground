using UnityEngine;
using System.Collections;

public class ResetGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI ()
    {
        if (GUI.Button(new Rect(20, 40, 80, 20), "Reset"))
            Application.LoadLevel(0);
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}
