using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScena : MonoBehaviour
{
    public void LoadRecorrido()
    {
        ManagerScenas.Instance.Transicion("Recorrido");
    }
    public void LoadAR()
    {
        ManagerScenas.Instance.Transicion("ARCatedral");
    }
}
