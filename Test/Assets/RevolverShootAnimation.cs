using UnityEngine;
using System.Collections;

public class RevolverShootAnimation : MonoBehaviour
{
    private bool isLoaded = true;

    public float openAngle = 90f;
    public float closeAngle = 0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    if (isLoaded)
        //    {
        //        transform.Rotate(Vector3.left, 45);
        //        transform.Rotate(Vector3.right, 45); 
                
        //        //Debug.Log("open"+transform.localRotation);
        //    }
        //    else
        //    {
        //        Quaternion targetRotation2 = Quaternion.Euler(0, closeAngle, 0);
        //        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, 2f * Time.deltaTime);
        //    }
        //}
    }
}
