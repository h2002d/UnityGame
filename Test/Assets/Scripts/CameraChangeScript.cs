using UnityEngine;
using System.Collections;

public class CameraChangeScript : MonoBehaviour {
    public Camera cam1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeCameraState(bool state)
    {
        cam1.enabled = state;
    }
}
