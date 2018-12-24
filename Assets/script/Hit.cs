using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

    public GameObject unityChan;
    private bool botton = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (botton == true)
        {
            
            botton = false;
        }

    }

    void OnTriggerEnter()
    {
        botton = true;
        
    }


}
