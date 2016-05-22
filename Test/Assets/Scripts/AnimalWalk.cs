using UnityEngine;
using System.Collections;

public class AnimalWalk : MonoBehaviour {
    private bool hited = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * (hited ? 3*Time.deltaTime: Time.deltaTime));
	}

    public void OnHited()
    {
        hited = true;
    }
}
