using UnityEngine;
using System.Collections;

public class GUICH : MonoBehaviour {

    public Texture2D CrossHair;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2, 24, 24), CrossHair);
    }
}
