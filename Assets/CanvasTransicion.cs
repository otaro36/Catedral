using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTransicion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameScene").GetComponent<ManagerScenas>().canvasTransition = this.gameObject;
        ManagerScenas.Instance.Intro();
    }


}
