using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ManagerIglesias : MonoBehaviour
{
    public string[] title;
    public string[] description;
    public TMP_Text tmpTitle;
    public TMP_Text tmpDescrption;
    public GameObject canvasInfo;
    // Start is called before the first frame update
    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void ChangeInfo(int id)
    {
        tmpTitle.text = title[id];
        tmpDescrption.text = description[id];
        canvasInfo.SetActive(true);
    }
}
