using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public List<GameObject> Iglesias;
    public int x;
    //public SwipeInputManager swipeInputManager;

    /*private void OnEnable()
    {
        swipeInputManager.OnSwipeLeft += PreviusPage;
        swipeInputManager.OnSwipeRight += NextPage;
    }
    private void OnDisable()
    {
        swipeInputManager.OnSwipeLeft -= PreviusPage;
        swipeInputManager.OnSwipeRight -= NextPage;
    }*/

    public void PreviusPage()
    {
        
        x--;
        if (x < 0)
            x = Iglesias.Count-1;
        for (int i = 0; i < Iglesias.Count; i++)
        {
            Iglesias[i].SetActive(false);
            Iglesias[x].SetActive(true);
        }
    }

    public void NextPage()
    {
        x++;
        if (x>=Iglesias.Count)
        {
            x = 0;
        }
        for (int i = 0; i < Iglesias.Count; i++)
        {
            Iglesias[i].SetActive(false);
            Iglesias[x].SetActive(true);
        }
    }
    public void DesIglesias()
    {
        for (int i = 0; i < Iglesias.Count; i++)
        {
            Iglesias[i].SetActive(false);
        }
    }

}
