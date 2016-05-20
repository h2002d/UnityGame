using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour {

    public Transform player;
    public float showDistance = 2f;
    public MeshRenderer textMesh;
	// Use this for initialization
	void Start () {
        //textMesh = gameObject.GetComponent("");
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, player.position) < showDistance)
            textMesh.enabled = true;
        else
            textMesh.enabled = false;
	}
}
