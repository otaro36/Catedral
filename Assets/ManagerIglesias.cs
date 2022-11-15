using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerIglesias : MonoBehaviour
{
    public string[] title;
    public string[] description;
    public Sprite[] spriteIglesia;
    public TMP_Text tmpTitle;
    public TMP_Text tmpDescrption;
    public Image tmpImage1;
    public Image tmpImage2;
    public Image tmpImage3;
    public Button tmpButton;
    public GameObject canvasInfo;
    public GameObject[] iglesias;
    // Start is called before the first frame update
    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void ChangeInfo(int id)
    {
        tmpTitle.text = title[id];
        tmpDescrption.text = description[id];
        switch (id)
        {
            case 0:
                //1.	Catedral de la Inmaculada Concepción (Concepción de La Vega)
                tmpImage1.sprite = spriteIglesia[0];
                tmpImage1.sprite = spriteIglesia[1];
                tmpImage1.sprite = spriteIglesia[2];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/1vPLtGrgPJDpdFRPA"));
                break;
            case 1:
                //3.	Catedral de Santiago Apóstol 
                tmpImage1.sprite = spriteIglesia[6];
                tmpImage1.sprite = spriteIglesia[7];
                tmpImage1.sprite = spriteIglesia[8];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/1594VfAWhjrC61EZ6"));

                break;
            case 2:
                //2.	Catedral Primada de América
                tmpImage1.sprite = spriteIglesia[3];
                tmpImage1.sprite = spriteIglesia[4];
                tmpImage1.sprite = spriteIglesia[5];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/zUP5sJ2TaRSy753U7"));
                break;
            case 3:
                //5.	El Santuario de San Dionisio
                tmpImage1.sprite = spriteIglesia[12];
                tmpImage1.sprite = spriteIglesia[13];
                tmpImage1.sprite = spriteIglesia[14];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/VU7UfiJemdJXjpuE9"));
                break;
            case 4:
                //4.	Basílica de Higüey
                tmpImage1.sprite = spriteIglesia[9];
                tmpImage1.sprite = spriteIglesia[10];
                tmpImage1.sprite = spriteIglesia[11];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/MbCrQMTuQAqVWK866"));
                break;
            default:
                break;
        }
        if (canvasInfo.activeInHierarchy)
        {
            canvasInfo.SetActive(false);
        }
        else
        {
            canvasInfo.SetActive(true);
        }
    }
    public void DescIglesias(int id)
    {
        switch (id)
        {
            case 0:
                iglesias[0].SetActive(true);
                iglesias[1].SetActive(false);
                iglesias[2].SetActive(false);
                iglesias[3].SetActive(false);
                iglesias[4].SetActive(false);
                break;
            case 1:
                iglesias[0].SetActive(false);
                iglesias[1].SetActive(true);
                iglesias[2].SetActive(false);
                iglesias[3].SetActive(false);
                iglesias[4].SetActive(false);
                break;
            case 2:
                iglesias[0].SetActive(false);
                iglesias[1].SetActive(false);
                iglesias[2].SetActive(true);
                iglesias[3].SetActive(false);
                iglesias[4].SetActive(false);
                break;
            case 3:
                iglesias[0].SetActive(false);
                iglesias[1].SetActive(false);
                iglesias[2].SetActive(false);
                iglesias[3].SetActive(true);
                iglesias[4].SetActive(false);
                break;
            case 4:
                iglesias[0].SetActive(false);
                iglesias[1].SetActive(false);
                iglesias[2].SetActive(false);
                iglesias[3].SetActive(false);
                iglesias[4].SetActive(true);
                break;
            default:
                break;
        }
    }
    public void ActivateIglesias()
    {
        for (int i = 0; i < iglesias.Length; i++)
        {
            iglesias[i].SetActive(true);
        }
    }


}
