using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text nameCapilla;
    public TMP_Text descriptionCapilla;
    public Image imageCapailla;
    public Button nextCapilla;
    public Button afterCapilla;
    public Button mainMenu;
    public string[] textNameCapilla;
    public string[] textDescripCapilla;
    public Sprite[] imageCapilla;
    public int x;


    // Start is called before the first frame update
    void Start()
    {
        nameCapilla.text = textNameCapilla[x];
        descriptionCapilla.text = textDescripCapilla[x];
        imageCapailla.sprite = imageCapilla[x];
        mainMenu.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("MainMenu"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextsCapilla()
    {
        x++;
        if (x >= 7)
        {
            x = 7;
        }
        nameCapilla.text = textNameCapilla[x];
        descriptionCapilla.text = textDescripCapilla[x];
        imageCapailla.sprite = imageCapilla[x];
    }
    public void AfterCapilla()
    {
        x--;
        if (x <= 0)
        {
            x = 0;
        }
        nameCapilla.text = textNameCapilla[x];
        descriptionCapilla.text = textDescripCapilla[x];
        imageCapailla.sprite = imageCapilla[x];
    }
}
