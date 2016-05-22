using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Vehicles.Car;

public class GetIntoCar : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;
    public Camera cam1;
    public Camera cam2;
    void Start()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("F clicked");

            cam1.enabled = false;
            cam2.enabled = true;
            fpc.enabled = true;
            GameObject.Find("Car").gameObject.GetComponent<CarUserControl>().enabled = false;
            gameObject.transform.localPosition = new Vector3(GameObject.Find("Car").transform.localPosition.x + 8, GameObject.Find("Car").transform.localPosition.y, GameObject.Find("Car").transform.localPosition.z);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            print("G clicked");
            cam1.enabled = true;
            cam2.enabled = false;
            fpc.enabled = false;
            GameObject.Find("Car").GetComponent<CarUserControl>().enabled = true;
            gameObject.transform.localPosition = new Vector3(GameObject.Find("Car").transform.localPosition.x+8,GameObject.Find("Car").transform.localPosition.y,GameObject.Find("Car").transform.localPosition.z);
        }
    }
}
