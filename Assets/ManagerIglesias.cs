using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerIglesias : MonoBehaviour
{
    public static ManagerIglesias Instance;
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
    public bool tutorial;
    public GameObject tutorialCanvas;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject.Find("GameScene").GetComponent<ManagerScenas>().ManagerIglesias = this;
    }
    public void ChangeInfo(int id)
    {
        tmpTitle.text = title[id];
        tmpDescrption.text = description[id];
        switch (id)
        {
            case 0:
                //1.	Catedral de la Inmaculada Concepci�n (Concepci�n de La Vega)
                tmpImage1.sprite = spriteIglesia[0];
                tmpImage2.sprite = spriteIglesia[1];
                tmpImage3.sprite = spriteIglesia[2];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/1vPLtGrgPJDpdFRPA"));
                break;
            case 1:
                //3.	Catedral de Santiago Ap�stol 
                tmpImage1.sprite = spriteIglesia[6];
                tmpImage2.sprite = spriteIglesia[7];
                tmpImage3.sprite = spriteIglesia[8];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/1594VfAWhjrC61EZ6"));

                break;
            case 2:
                //2.	Catedral Primada de Am�rica
                tmpImage1.sprite = spriteIglesia[3];
                tmpImage2.sprite = spriteIglesia[4];
                tmpImage3.sprite = spriteIglesia[5];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/zUP5sJ2TaRSy753U7"));
                break;
            case 3:
                //5.	El Santuario de San Dionisio
                tmpImage1.sprite = spriteIglesia[12];
                tmpImage2.sprite = spriteIglesia[13];
                tmpImage3.sprite = spriteIglesia[14];
                tmpButton.onClick.RemoveAllListeners();
                tmpButton.onClick.AddListener(() => Application.OpenURL("https://goo.gl/maps/VU7UfiJemdJXjpuE9"));
                break;
            case 4:
                //4.	Bas�lica de Hig�ey
                tmpImage1.sprite = spriteIglesia[9];
                tmpImage2.sprite = spriteIglesia[10];
                tmpImage3.sprite = spriteIglesia[11];
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
    public void Tutorial()
    {
        if (tutorial)
        {
            StartCoroutine(AnimacionTutorial());
        }
    }
    IEnumerator AnimacionTutorial()
    {
        tutorialCanvas.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        tutorialCanvas.SetActive(false);
    }
    
}
