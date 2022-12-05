using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonUrl : MonoBehaviour
{
    public void LoadUrl(string url)
    {
        Application.OpenURL(url);
    }
}
