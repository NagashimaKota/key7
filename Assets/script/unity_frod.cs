using UnityEngine;
using System.Collections;

public class unity_frod : MonoBehaviour {

    public float speed_y = 0.01f;
    public float speed_z = 0.01f;
    Vector3 pos;


    // Use this for initialization
    void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
        //pos.y += speed_y;
        pos.z += speed_z;
        transform.position = pos;
    }
}
