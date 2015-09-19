using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class FollowLocalPlayer : NetworkBehaviour {

    
    public Transform target;

	
	
	// Update is called once per frame
	void Update () {

        transform.position = target.position + Vector3.up;
	
	}
}
