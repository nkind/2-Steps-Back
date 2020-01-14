using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GpsSystem : MonoBehaviour
{
    public static GpsSystem Instance { set; get; }
    //real world initial (A point to draw around, the center of the fake world)
    Vector2 rinit;
    //our real world position
    Vector2 rCurrentPos;
    //our fake initial point
    Vector2 fInit;
    //fake in game position
    Vector2 fCurrentPos;
    //Hitbox game object for locations
    public GameObject aLocation;
    //Canvas Scale X and Y
    float csX = 0.28856f; //0.6612515f; 0.66... Is scale for Zoom 18.
    float csY = 0.48567f; //1.05708245243129f; 1.057... Is scale for Zoom 18
    //Offset Y to position the hit box around centered on pin center rather than pin point
    float YOffSet = 0.75f;

    float idleTimer = 3.5f;
    float time;

    //Storage of the all locations
    List<GameObject> allLocations;
    //Longitude and Latitude, will be set via phone gps.
    public float lon;
    public float lat;
    //The root object, Named "World" in the scene.
    //This is no longer used, but left it for future use. If you need to send messages to multiple
    //game objects, Call Ex. root.BroadcastMessage("updateLocations", rCurrentPos);
    Transform root;

    //Simple animations
    Animator anim;

    // Since long/lat in crease by very small amounts per step this will not
    // work for placing object in the game world, so increase it by Scale.
    public float Scale;
    // For computer testing
    public bool FakingLocation;

    //Adding Markers purposes
    //public List<string> markers;
    public Dictionary<string, string> markers;
    //How close the player has to be in unity units for the marker to appear.
    int xThreshHold = 6;
    int yThreshHold = 5;

    // Start is called before the first frame update
    void Awake()
    {
        markers = new Dictionary<string, string>();
        //Portrait only. Landscape messes up scales. Google Api does translate nicely though.
        Screen.orientation = ScreenOrientation.Portrait;
        //Instance so we have access via Google.
        Instance = this;

        //Initializations
        fInit = Vector2.zero;
        allLocations = new List<GameObject>();
        //Map will be 0.5 meters precise.
        Input.location.Start(0.5f);
        //make sure compass is on
        Input.compass.enabled = true;
        anim = gameObject.GetComponent<Animator>();
        //We are not walking at the start
        anim.SetBool("WalkingRight", false);
        anim.SetBool("WalkingLeft", false);
        //Draw around bowl
        rinit = new Vector2(-106.634090f, 52.131082f);

        // Change this to spawn in a more meaningful way.
        SpawnLocation(-106.6393f, 52.1302f, "Health Sci");
        //markers.Add("Health Sci", "%7Clabel:H%7C52.1302,-106.6393");

        SpawnLocation(-106.636f, 52.1323f, "Thorv");
        //markers.Add("Thorv", "%7Clabel:T%7C52.1323,-106.636");

        SpawnLocation(-106.6361f, 52.1313f, "SG");
        //markers.Add("SG", "%7Clabel:S%7C52.1313,-106.6361");

        SpawnLocation(-106.6344f, 52.1318f, "Geo");
        //markers.Add("Geo", "%7Clabel:G%7C52.1318,-106.6344");

        SpawnLocation(-106.6327f, 52.1307f, "Admin");
        //markers.Add("Admin", "%7Clabel:A%7C52.1307,-106.6327");

        if (FakingLocation)//Set your long/lat to where ever you want to be
        {
            lat = 52.1313f;//SnelGro currently
            lon = -106.6361f;//SnelGro currently
        }
        //initialize the root. Again not used, Left just in case. Can remove or use later.
        root = this.transform;
        while (root.parent != null)
        {
            root = root.parent;
        }
    }

    //Update position via Coroutine.
    IEnumerator updatePosition()
    {

        if (FakingLocation == false)
        {
            if (Input.location.isEnabledByUser == false)
            {
                Debug.Log("Failed, no location enabled");
            }
            //how long we wait to see if location is enabled ex. no wifi connection.
            int maxwait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxwait > 0)
            {
                yield return new WaitForSeconds(1);
                maxwait--;
            }

            if (maxwait < 1)
            {
                Debug.Log("Connection Time out");
                yield return null;
            }

            if (Input.location.status == LocationServiceStatus.Failed)
            {
                Debug.Log("location failed");
                yield return null;
            }
            else
            {
                SetLocation(Input.location.lastData.longitude, Input.location.lastData.latitude);
            }
        }
        else //We are faking and can update via inspector.
        {
            SetLocation(lon, lat);
        }
    }

    //Setting the players location in the game world based off the long/lat gps cords.
    void SetLocation(float longitude, float latitude)
    {
        rCurrentPos = new Vector2(longitude, latitude);
        //delta current - initial
        Vector2 delta = new Vector2(rCurrentPos.x - rinit.x, rCurrentPos.y - rinit.y);
        //set fake current pos. our longitude and latitude move very little 
        //so we multiply it by our large scale to move the player in unity world
        fCurrentPos = delta * Scale;
        //Gets a bit messy here.
        float oldX = this.transform.position.x;
        float oldY = this.transform.position.y;
        this.transform.position = new Vector2(fCurrentPos.x, fCurrentPos.y);
        float newX = this.transform.position.x;
        float newY = this.transform.position.y;
        //Testing purposes
        //GameObject.Find("LocationText").GetComponent<Text>().text = "lat: " + lat + " | lon: " + lon;
        if ((newX > oldX || (newY > oldY)) && (newX != 0 && oldX != 0))
        {
            /* IF WE want to scale the animation time by the movement
            float xchange = Mathf.Abs(newX - oldX);
            float ychange = Mathf.Abs(newY - oldY);
            */
            //Set time
            time = idleTimer;
            anim.SetBool("WalkingRight", true);

        }
        else if (time <= 0) { anim.SetBool("WalkingRight", false); }
        if ((newX < oldX || (newY < oldY)) && (newX != 0 && oldX != 0))
        {
            /*
            float xchange = Mathf.Abs(newX - oldX);
            float ychange = Mathf.Abs(newY - oldY);
            */
            //Set time
            time = idleTimer;
            anim.SetBool("WalkingLeft", true);

        }
        else if (time <= 0) { anim.SetBool("WalkingLeft", false); }
        if (root != null && (oldX != newX || oldY != newY))
        {
            //location has moved so reset timer.
            //Set time to a flat estimation of walk time.
            time = idleTimer;

            //For all the locations update them as the player moves based on some sick math.
            foreach (GameObject pos in allLocations)
            {
                float locX = pos.GetComponent<Location>().LocPos.x;
                float locY = pos.GetComponent<Location>().LocPos.y;
                pos.GetComponent<Location>().fakePos = new Vector2((((locX - rCurrentPos.x) * Scale) * csX) + newX, (((locY - rCurrentPos.y) * Scale) * csY) + newY + YOffSet);
                bool CloseX = (Mathf.Abs(pos.GetComponent<Location>().GameWorldOrgin.x - this.transform.position.x) <= xThreshHold);
                bool CloseY = (Mathf.Abs(pos.GetComponent<Location>().GameWorldOrgin.y - this.transform.position.y) <= yThreshHold);
                if (CloseX && CloseY)
                {
                    pos.GetComponent<Location>().tappable.enabled = true;
                    if (!markers.ContainsKey(pos.GetComponent<Location>().tag) && allowAccess(pos.GetComponent<Location>().tag))
                    {
                        addMarker(locX, locY, pos.GetComponent<Location>().tag);
                    }
                }
                else
                {
                    pos.GetComponent<Location>().tappable.enabled = false;
                    removeMarker(pos.GetComponent<Location>().tag);
                }
            }
            //printDict();
        }
    }
    //A function that determinds if markers will appear on the map determind by conditions that allow the player to advance
    public bool allowAccess(string key)
    {
        //Health Sci is always ok
        if (key == "Health Sci")
        {
            return true;
        }
        //If player prefs of the key is 1, then its accessible.
        else if (PlayerPrefs.GetInt(key) == 1)
        {
            return true;
        }
        else return false;

    }
    public void printDict()
    {
        string theDict = "-";
        foreach (KeyValuePair<string, string> marker in markers)
        {
            theDict += marker.Key + " is in the Dict\n";
        }
        Debug.Log(theDict);
    }
    public void addMarker(float lon, float lat, string key)
    {
        char label = key.ToCharArray()[0];
        string markerURL = "%7Clabel:" + label + "%7C" + lat + "," + lon;
        markers.Add(key, markerURL);
    }

    public void removeMarker(string key)
    {
        markers.Remove(key);
    }

    //Spawning locations MAKE SURE TO CREATE THE TAGS.
    void SpawnLocation(float longitude, float latitude, string tag)
    {
        Vector2 LocPos = new Vector2(longitude, latitude);
        Vector2 delta = new Vector2(LocPos.x - rinit.x, LocPos.y - rinit.y);
        Vector2 gameLoc = delta * Scale;

        GameObject loc = Instantiate(aLocation, new Vector2(gameLoc.x * csX, gameLoc.y * csY + YOffSet), Quaternion.identity);
        //Make it a child of the world for tappability
        loc.transform.parent = GameObject.Find("World").transform;
        loc.AddComponent<BoxCollider2D>();
        loc.transform.localScale = new Vector2(2, 2);
        loc.AddComponent<Location>();
        loc.tag = tag;
        loc.GetComponent<Location>().LocPos = LocPos;
        loc.GetComponent<Location>().GameWorldOrgin = new Vector2(gameLoc.x, gameLoc.y);
        allLocations.Add(loc);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(updatePosition());
        if (!FakingLocation)
        {
            lat = rCurrentPos.y;
            lon = rCurrentPos.x;
        }
    }
}

