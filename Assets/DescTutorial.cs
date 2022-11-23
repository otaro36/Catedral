using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescTutorial : MonoBehaviour
{
    public GameObject panelTuto;
    public void Tutorial()
    {
        if (panelTuto.activeInHierarchy)
        {
            panelTuto.SetActive(false);
        }
        else
        {
            panelTuto.SetActive(true);
        }
    }
    public void DsetPanelTuto()
    {
        panelTuto.SetActive(false);
    }
}
