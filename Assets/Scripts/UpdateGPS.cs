using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPS : MonoBehaviour {
    public Text coordinates;
    public float latitude;
    public float longitude;


    private void FixedUpdate() {
        latitude = GPS.Instance.latitude;
        longitude = GPS.Instance.longitude;
        coordinates.text = "LAT: " + GPS.Instance.latitude.ToString() + "\nLONG: " + GPS.Instance.longitude.ToString();
        coordinates.color = Color.yellow;
    }
}
