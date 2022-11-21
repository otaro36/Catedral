using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfoIglesias : MonoBehaviour
{
    public Button button;
    public ManagerIglesias managerIglesias;
    public int id;
    public GameObject canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => managerIglesias.ChangeInfo(id));
            button.onClick.AddListener(() => canvas.SetActive(true));
            button.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            button.gameObject.SetActive(false);
            canvas.SetActive(false);
        }
    }
    /*public void CerrarInfo()
    {
        if (canvas.activeInHierarchy)
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
        }
    }*/
}
