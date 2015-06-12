using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode] 
public class Staircase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    public int numStairs = 16;
    public Vector3 stairSize = new Vector3(16, 1, 4);
    public float    stairDepth = -3f,
                    stairHeight = 1.5f;

    public Material stairMaterial;

	// Update is called once per frame
	void Update () {
        if (Application.isPlaying)
        {
            this.enabled = false;
            return;
        }

        List<Transform> dump = new List<Transform>();

        foreach (Transform child in transform)
        {
            dump.Add(child);
        }

        foreach (var child in dump)
        {
            DestroyImmediate(child.gameObject);
        }

        GameObject parent = new GameObject("Stair Elements (managed)");
        parent.transform.parent = transform;
        parent.transform.localPosition = Vector3.zero;


        for (int i = 0; i < numStairs; i++)
        {
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.transform.parent = parent.transform;
            box.transform.localPosition = new Vector3(0f, stairHeight * i, stairDepth * i);
            box.transform.localScale = stairSize;
            if (stairMaterial != null)
                box.GetComponent<MeshRenderer>().material = stairMaterial;


        }




	}
}
