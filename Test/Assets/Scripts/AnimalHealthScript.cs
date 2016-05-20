using UnityEngine;
using System.Collections;

public class AnimalHealthScript : MonoBehaviour
{

    public int Health = 100;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("Object Destroyed");
            Destroy(gameObject);
        }
    }
    public void Hited(int hitAmount)
    {
        Debug.Log("Object Hited");
        Health -= hitAmount;
    }
}
