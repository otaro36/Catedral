using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class GeoLocal : MonoBehaviour
{
    private string urlMap = "";
    public RawImage imageMap;
    public Text latitudText;
    public Text longitudText;
    public int zoom = 20;
    // Start is called before the first frame update
    void Start()
    {
        GetMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GetMap()
    {
        Input.location.Start();
        float latitud = Input.location.lastData.latitude;
        yield return latitud;
        float longitud = Input.location.lastData.longitude;
        yield return longitud;
        urlMap = "http://maps.google.com/maps/api/staticmap?center=" + latitud + "," + longitud + "&markers=color:red%7clabel:s%" + latitud + "," + longitud + "&zoom" + zoom + "&size=512x512" + "&maptype=hybrid&markers=color:red|label:|" + latitud + "," + longitud + "&type=hybrid&sensor=true?a.jpg";
        WWW www = new WWW(urlMap);
        yield return www;
        imageMap.texture = www.texture;
        //latitudText.text = "" + latitud;
        //longitudText.text = "" + longitud;
    }
}
