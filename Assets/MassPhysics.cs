using UnityEngine;
using System.Collections;

public class MassPhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    bool done = false;

    public PhysicMaterial physicalMaterial;
    public Material opticalMaterial;

    void OnTriggerEnter(Collider collider)
    {
        if (!done && collider.transform.gameObject.layer == 9)
        {
            done = true;
            Debug.Log(collider.transform.gameObject.layer);
            for (int i = 0; i < 2000; i++)
            {
                GameObject child = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                child.transform.localScale = Vector3.one * 2f;
                if (opticalMaterial != null)
                    child.GetComponent<MeshRenderer>().material = opticalMaterial;
                child.transform.parent = transform.parent;
                child.transform.position = new Vector3(
                                            Random.RandomRange(-20f, 20f),
                                            Random.RandomRange(10f, 20f),
                                            Random.RandomRange(-20f, 20f));
                child.AddComponent<Rigidbody>().useGravity = true;
                child.GetComponent<SphereCollider>().material = physicalMaterial;
            }
        }

    }


	// Update is called once per frame
	void Update () {
	
	}
}
