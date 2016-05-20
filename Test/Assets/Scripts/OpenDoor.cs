using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour
{
    public bool open = true;
    public float openAngle = 90f;
    public float closeAngle = 0f;
    // Use this for initialization
    void Start()
    {

    }


    public void ChangeDoorState()
    {
        open = !open;

    }
    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, openAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, 2f * Time.deltaTime);
            //Debug.Log("open"+transform.localRotation);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, closeAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, 2f * Time.deltaTime);
        }
    }
}
