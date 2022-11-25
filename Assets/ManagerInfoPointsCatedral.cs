using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerInfoPointsCatedral : MonoBehaviour
{
    public string[] titlePanel;
    public string[] InfoPanel;
    public GameObject panelInfo;
    public TMP_Text title;
    public TMP_Text text;

    public void ChangeInfo(int id)
    {
        title.text=titlePanel[id];
        text.text=InfoPanel[id];
        panelInfo.SetActive(true);
    }
}
