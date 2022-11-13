using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
//sing UnityEngine.XR.ARSubsystems;

public class MultiTarjetManager : MonoBehaviour
{
    /*[SerializeField]private ARTrackedImageManager aRTrackedImageManager;
    [SerializeField]private GameObject[] aRModelToPlace;

    private Dictionary<string,GameObject> aRModels=new Dictionary<string, GameObject>();
    private Dictionary<string,bool>modelState=new Dictionary<string, bool>();

    // Start is called before the first frame update
    void Start()
    {
        foreach(var aRmodel in aRModelToPlace)
        {
            GameObject newARModel = Instantiate(aRmodel,Vector3.zero,Quaternion.identity);
            newARModel.name=aRmodel.name;
            aRModels.Add(newARModel.name,newARModel);
            newARModel.SetActive(false);
            modelState.Add(newARModel.name,false);
        }
    }
    private void OnEnable()
    {
        aRTrackedImageManager.trackedImagesChanged+=ImageFound;
    }
    /// This function is called when the behaviour becomes disabled or inactive.
    private void OnDisable()
    {
        aRTrackedImageManager.trackedImagesChanged-=ImageFound;
    }

    private void ImageFound(ARTrackedImagesChangedEventArgs eventData)
    {
        foreach (var trackedImage in eventData.added)
        {
            ShowARModel(trackedImage);
        }
        foreach (var trackedImage in eventData.updated)
        {
            if (trackedImage.trackingState==TrackingState.Tracking)
            {
                ShowARModel(trackedImage);
            }
            else if(trackedImage.trackingState==TrackingState.Limited)
            {
                HideARModel(trackedImage);
            }
        }
    }
    private void ShowARModel(ARTrackedImage trackedImage)
    {
        bool isModelActivate=modelState[trackedImage.referenceImage.name];
        if (!isModelActivate)
        {
            GameObject aRModel =aRModels[trackedImage.referenceImage.name];
            aRModel.transform.position=trackedImage.transform.position;
            aRModel.SetActive(true);
            modelState[trackedImage.referenceImage.name]=true;
        }
        else
        {
            GameObject aRModel =aRModels[trackedImage.referenceImage.name];
            aRModel.transform.position=trackedImage.transform.position;
        }
    }
    private void HideARModel(ARTrackedImage trackedImage)
    {
                bool isModelActivate=modelState[trackedImage.referenceImage.name];
        if (isModelActivate)
        {
            GameObject aRModel =aRModels[trackedImage.referenceImage.name];
            aRModel.SetActive(false);
            modelState[trackedImage.referenceImage.name]=false;
        }
    }*/
}
