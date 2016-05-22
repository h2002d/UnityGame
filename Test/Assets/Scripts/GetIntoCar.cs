using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Vehicles.Car;

public class GetIntoCar : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;
   
    public Camera cam2;
    private bool inCar = false;
    private GameObject Car;
    void Start()
    {
        cam2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            print("F clicked00");
            if (inCar)
            {
                print("inCar geted");
                cam2.enabled = true;
                fpc.enabled = true;
                fpc.GetComponent<GUICH>().enabled = true;
                Car.GetComponentInParent<CarUserControl>().enabled = false;
                Car.GetComponentInParent<CameraChangeScript>().ChangeCameraState(false);
                print(Car);
                gameObject.transform.position = new Vector3(Car.transform.position.x, Car.transform.position.y + 2, Car.transform.position.z);
                inCar = false;
            }
            else
            {
                print("Incar False");
                Ray ray = new Ray(transform.position, transform.forward);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 500))
                {
                    print("Ray Sent:" + hit.collider.name.ToString());
                    if (hit.collider.CompareTag("CarBody"))
                    {
                        Car = hit.collider.gameObject;
                        print("Collision");
                        print(Car);
                        Car.GetComponentInParent<CameraChangeScript>().ChangeCameraState(true);
                        cam2.enabled = false;
                        fpc.enabled = false;
                        fpc.GetComponent<GUICH>().enabled = false;
                        Car.GetComponentInParent<CarUserControl>().enabled = true;
                        gameObject.transform.position = new Vector3(Car.transform.position.x, Car.transform.position.y, Car.transform.position.z - 100);
                        inCar = true;
                    }

                }

            }
        }
    }
}
