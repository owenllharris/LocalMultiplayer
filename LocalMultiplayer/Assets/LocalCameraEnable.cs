using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class LocalCameraEnable : NetworkBehaviour {

    public GameObject cam;
    public GameObject camHolder;

	// Use this for initialization
	void Start () {
        if (isLocalPlayer)
        {
            cam = GameObject.Find("PlayerCamera");
            cam.transform.position = camHolder.transform.position;
            cam.transform.parent = camHolder.transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
