using UnityEngine;
using System.Collections;

public class RevolverShootAnimation : MonoBehaviour
{
    public GameObject projectile;
    public AudioClip shootSound;
    private object lockThis = new object();

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    private bool shooted = false;
    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            StartCoroutine(Example());
        }
    }
    IEnumerator Example()
    {
        if (transform.localRotation == Quaternion.Euler(0, 0, 0))
        {
            transform.Rotate(-40, 0, 0);
            print("0.5 Seconds start");
            yield return new WaitForSeconds(0.075f);
            print("0.5 Seconds end");
            transform.Rotate(40, 0, 0);
        }
    }
}
