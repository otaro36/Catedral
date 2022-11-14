using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerInfoIglesias : MonoBehaviour
{
    public string title;
    public string Description;
    public TMP_Text titleText;
    public TMP_Text descriptionText;
    public GameObject canvas; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            titleText.text = title;
            descriptionText.text = Description;
            canvas.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvas.SetActive(false);

        }
    }
    public void CerrarInfo()
    {
        if (canvas.activeInHierarchy)
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
        }
    }
}
