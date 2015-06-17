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
        int i = 3;
        GUI.color = Color.black;
        GUI.Label(new Rect(20, (i++)*20, 260, 20), "Alt+Click: fire sphere");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "Space: Put force on objects");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "Ctrl+Space: Increase force");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "ASDW: Move character");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "Shift+ASDW: Move faster");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "Page up/down: Zoom camera");
        GUI.Label(new Rect(20, (i++) * 20, 260, 20), "Arrow keys: Rotate camera");
        GUI.Label(new Rect(20, (i++) * 20, 460, 20), "Fire sphere through blue gate to mass-spawn spheres");
        GUI.Label(new Rect(20, (i++) * 20, 460, 20), "Click on floating board to release bouncy spheres");
        GUI.Label(new Rect(20, (i++) * 20, 460, 20), "Move to vehicle to mount, Esc to unmount/quit");
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}
