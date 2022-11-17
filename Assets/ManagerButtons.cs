using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerButtons : MonoBehaviour
{
    public Button ARcore;
    public Button infoIglesia;
    public ManagerScenas ManagerScenas;
    public GameObject panelinicio;
    public GameObject panelSecundario;
    // Start is called before the first frame update
    void Start()
    {
        ARcore.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("ARCatedral"); });
        infoIglesia.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("Recorrido"); });
        ManagerScenas=GameObject.FindGameObjectWithTag("ManagerScenas").GetComponent<ManagerScenas>();
        if (ManagerScenas.menuInicio)
        {
            panelinicio.SetActive(false);
            panelSecundario.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
