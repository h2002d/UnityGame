using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
    public float DistanceBullet = 500.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, DistanceBullet))
            {
                Debug.Log("Ray Sent");
                if (hit.collider.CompareTag("Body"))
                {
                    Debug.Log("Body Hited");
                    hit.collider.gameObject.GetComponentInParent<AnimalHealthScript>().Hited(50);
                }
                else if (hit.collider.CompareTag("Head"))
                {
                    Debug.Log("Head Hited");
                    hit.collider.gameObject.GetComponentInParent<AnimalHealthScript>().Hited(100);
                }
            }
        }
	}
}
