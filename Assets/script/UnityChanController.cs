using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
    private Vector3 v3;
    

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {

        v3 = agent.transform.position;

        if (Input.GetButton("Jump"))
        {
            Debug.Log("botton");
            //agent.SetDestination(target.transform.position);

            v3.y += 0.3f;
            v3.z += 0.47f;

            agent.SetDestination(v3);
        }
        else
        {
            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SteamVR.instance.hmd.ResetSeatedZeroPose();
        }


    }
    

    void OnTriggerEnter()
    {
        agent.Warp(new Vector3(0f, 2.44f, 2.69f));
    }

}
