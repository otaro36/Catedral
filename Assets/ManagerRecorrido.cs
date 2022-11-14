using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerRecorrido : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Debug.Log(Screen.orientation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
        Debug.Log(Screen.orientation);
    }
}
