using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerButtons : MonoBehaviour
{
    public Button ARcore;
    public Button infoIglesia;
    // Start is called before the first frame update
    void Start()
    {
        ARcore.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("ARCatedral"); });
        infoIglesia.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("Recorrido"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
