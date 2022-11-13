using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
//using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using TMPro;
public class PlaneManager : MonoBehaviour
{
    /*[SerializeField]private ARPlaneManager aRPlaneManager;
    [SerializeField]private GameObject model3DPrefac;
    [SerializeField]private ARPointCloudManager aRPointCloudManager;
    private List<ARPlane> planes = new List<ARPlane>();
    private GameObject model3Dplaced;
    [Range(0,10)]public float slider;
    public Slider sliderUI;
    public TMP_Text textPost;
    public TMP_Text textRot;
    public TMP_Text textSld;
    public Button mainMenu;
    private void OnEnable()
    {
        aRPlaneManager.planesChanged+=PlanesFound;
    }
    /// This function is called when the behaviour becomes disabled or inactive.
    private void OnDisable()
    {
        aRPlaneManager.planesChanged-=PlanesFound;
    }
    private void Start()
    {
        mainMenu.onClick.AddListener(delegate { ManagerScenas.Instance.Transicion("MainMenu"); });
    }
    /// Update is called every frame, if the MonoBehaviour is enabled.
    private void Update()
    {
        /*if (model3Dplaced!=null)
        {
            slider=sliderUI.value;
            textSld.text=slider.ToString();
            textPost.text="posicion"+model3Dplaced.transform.localPosition.x.ToString()+" x "+model3Dplaced.transform.localPosition.y.ToString()+" y "+model3Dplaced.transform.localPosition.z.ToString()+" z ";
            textRot.text="Rotacion"+model3Dplaced.transform.localRotation.x.ToString()+" x "+model3Dplaced.transform.localRotation.y.ToString()+" y "+model3Dplaced.transform.localRotation.z.ToString()+" z ";
            //model3Dplaced.transform.position=new Vector3(model3Dplaced.transform.position.x,model3Dplaced.transform.position.y+sliderUI.value,model3Dplaced.transform.position.z);
        }*/

    //}
    /*private void PlanesFound(ARPlanesChangedEventArgs planeData)
    {
        if (planeData.added!=null&&planeData.added.Count>0 )
        {
            planes.AddRange(planeData.added);           
        }
        foreach (var plane  in planes)
        {
            if (plane.extents.x*plane.extents.y>= 0.4 && model3Dplaced==null)
            {
                model3Dplaced=Instantiate(model3DPrefac);
                float yOffset = model3Dplaced.transform.localScale.y/2;
                model3Dplaced.transform.position=new Vector3(plane.center.x,plane.center.y+yOffset,plane.center.z);
                model3Dplaced.transform.forward=plane.normal;
                StopPlaneDetetion();

            }
        }
    }*/
    /*public void StopPlaneDetetion()
    {
        //aRPlaneManager.requestedDetectionMode=PlaneDetectionMode.None;
        foreach (var plane in planes)
        {
            plane.gameObject.SetActive(false);
        }
    }*/
}
