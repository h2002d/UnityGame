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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Clicked");
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, distance))
            {
                Debug.Log("Ray Sent");
                if (hit.collider.CompareTag("Door"))
                {
                    hit.collider.gameObject.GetComponent<OpenDoor>().ChangeDoorState();
                }
            }
        }

    }
}
