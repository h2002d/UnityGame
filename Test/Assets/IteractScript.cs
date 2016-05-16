using UnityEngine;
using System.Collections;

public class IteractScript : MonoBehaviour
{

    public float distance = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, distance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    hit.collider.gameObject.GetComponent<OpenDoor>().ChangeDoorState();
                }
            }
        }

    }

    
}
