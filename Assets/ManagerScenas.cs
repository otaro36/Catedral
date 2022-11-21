using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScenas : MonoBehaviour
{
    public static ManagerScenas Instance;
    public string scenas1= "MainMenu";
    public string scenas2= "InfoIglesias";
    public string scenas3= "ARCatedral";
    public string scenas4;
    public GameObject canvasTransition;
    public bool menuInicio;
    public ManagerIglesias ManagerIglesias;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //canvasTransition = GameObject.Find("CanvasTransicion");
        //
    }
    private void Start()
    {
        
    }

    public void Intro()
    {
        StartCoroutine(IntroTransicion());

    }
    IEnumerator IntroTransicion()
    {
        
        yield return new WaitForSecondsRealtime(5);
        canvasTransition.SetActive(false);
        ManagerIglesias.Tutorial();
    }
    public void Transicion(string scene)
    {
        Debug.Log("111");
        menuInicio = true;
        StartCoroutine(InitTransicion(scene));
    }

    IEnumerator InitTransicion(string scene)
    {
        canvasTransition.SetActive(true);
        canvasTransition.GetComponent<Animator>().SetBool("Inicio", false);
        yield return new WaitForSecondsRealtime(4);
        SceneManager.LoadScene(scene);
    }
    public void ChangeMenuInicio()
    {

    }
}
