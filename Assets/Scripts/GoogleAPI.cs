using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoogleAPI : MonoBehaviour
{
    //Google API
    public RawImage img;
    string url;
    public float lat;
    public float lon;
    LocationInfo li;
    private int zoom = 17;
    private int mapWidth = Screen.width;
    private int mapHeight = Screen.height;
    public enum mapType { roadmap, satellite, hybrid, terrain }
    public mapType mapSelected;
    public int scale;
    //public string marker1Color;
    //public string marker2Color;
    //public string marker3Color;

    //TODO : Change implementation of marker string to add markers easier. Or dont. Copy/Paste. W.E is easier.
    
    //public string[] markerColor;


    //TESTING
    //public GoogleMapMarker[] markers;
    IEnumerator Map()
    {
        List<string> markers = new List<string>();
        foreach(KeyValuePair<string, string> marker in GpsSystem.Instance.markers)
        {
            markers.Add(marker.Value);
        }
        string theMarkers = "";
        foreach (string m in markers)
        {
            theMarkers += "&markers=color:" + "green" + m;
        }
        //Debug.Log(theMarkers);
        url = "https://maps.googleapis.com/maps/api/staticmap?key=AIzaSyBQ79JE8tN7rL8HtkDDHCm3NADz77x36uc&center=" + lat + "," + lon +
                "&zoom=" + zoom +
                "&format=png&maptype=" + mapSelected +
                "&style=element:geometry%7Ccolor:0x212121&style=element:labels.icon%7Cvisibility:off&style=element:labels.text.fill%7Ccolor:0x757575&style=element:labels.text.stroke%7Ccolor:0x212121&style=feature:administrative%7Celement:geometry%7Ccolor:0x757575&style=feature:administrative.country%7Celement:labels.text.fill%7Ccolor:0x9e9e9e&style=feature:administrative.land_parcel%7Cvisibility:off&style=feature:administrative.locality%7Celement:labels.text.fill%7Ccolor:0xbdbdbd&style=feature:administrative.neighborhood%7Celement:geometry%7Ccolor:0x00ff00%7Cvisibility:on&style=feature:administrative.neighborhood%7Celement:geometry.fill%7Ccolor:0x00ff00%7Cvisibility:on&style=feature:administrative.neighborhood%7Celement:geometry.stroke%7Ccolor:0x00ff00%7Cvisibility:on&style=feature:landscape.man_made%7Celement:geometry.fill%7Ccolor:0xffffff%7Csaturation:-100%7Clightness:-100%7Cvisibility:on&style=feature:landscape.man_made%7Celement:geometry.stroke%7Ccolor:0x808877%7Cvisibility:on%7Cweight:2&style=feature:poi%7Celement:labels.text.fill%7Ccolor:0x757575&style=feature:poi.park%7Celement:geometry%7Ccolor:0x181818&style=feature:poi.park%7Celement:labels.text.fill%7Ccolor:0x616161&style=feature:poi.park%7Celement:labels.text.stroke%7Ccolor:0x1b1b1b&style=feature:road%7Celement:geometry.fill%7Ccolor:0x2c2c2c&style=feature:road%7Celement:labels.text.fill%7Ccolor:0x8a8a8a&style=feature:road.arterial%7Celement:geometry%7Ccolor:0x373737&style=feature:road.highway%7Celement:geometry%7Ccolor:0x3c3c3c&style=feature:road.highway.controlled_access%7Celement:geometry%7Ccolor:0x4e4e4e&style=feature:road.local%7Celement:labels.text.fill%7Ccolor:0x616161&style=feature:transit%7Celement:labels.text.fill%7Ccolor:0x757575&style=feature:water%7Ccolor:0x3df4fe%7Csaturation:100%7Clightness:100%7Cweight:8&style=feature:water%7Celement:geometry%7Ccolor:0x000000&style=feature:water%7Celement:geometry.fill%7Ccolor:0x0de7f2%7Cvisibility:simplified&style=feature:water%7Celement:geometry.stroke%7Ccolor:0x0000ff%7Cvisibility:simplified&style=feature:water%7Celement:labels.text.fill%7Ccolor:0x3d3d3d" +
                "&size=" + mapWidth + "x" + mapHeight +
                "&scale=" + scale + theMarkers +
                //"&markers=color:" + marker1Color + "%7Clabel:A%7C52.1244,-106.5963&markers=color:" + marker2Color + "%7Clabel:T%7C52.1323,-106.636&markers=color:" + marker3Color + "%7Clabel:H%7C52.1302,-106.6393" +
                //"&markers=color:" + marker1Color + "%7Clabel:S%7C52.1307,-106.6348&markers=color:" + marker2Color + "%7Clabel:N%7C52.1315,-106.6346&markers=color:" + marker3Color + "%7Clabel:E%7C52.1310,-106.6336" +
                //"&markers=color:" + marker1Color + "%7Clabel:S%7C52.1313,-106.6361&markers=color:" + marker2Color + "%7Clabel:A%7C52.1307,-106.6327&markers=color:" + marker3Color + "%7Clabel:G%7C52.1318,-106.6344" +
                "&key=AIzaSyBQ79JE8tN7rL8HtkDDHCm3NADz77x36uc" +
                "&callback=initMap";
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();

    }

    // Start is called before the first frame update
    void Start()
    {
        //markerColor = new string[3];
        //Google API
        //marker1Color = "green";
        //marker2Color = "blue";
        //marker3Color = "red";
        img = gameObject.GetComponent<RawImage>();

        StartCoroutine(Map());
        //-----
    }
    public float newlat;
    public float newlon;
    // Update is called once per frame
    void Update()
    {
        newlat = GpsSystem.Instance.lat;
        newlon = GpsSystem.Instance.lon;

        if (newlat != lat || newlon != lon)
        {
            lat = newlat;
            lon = newlon;
            StartCoroutine(Map());
        }
    }

}

