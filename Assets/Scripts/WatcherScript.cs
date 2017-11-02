using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WatcherScript : Photon.MonoBehaviour
{
    [SerializeField] TowerSelect towerselect;
    //Temp limit section begins
    int limit;
    public int towerlimit;
    public Text limitmsg;
    //Temp limit section ends
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (limit < towerlimit)
            {
                Vector3 TouchPos = Input.GetTouch(0).position;
                TouchPos.z = TouchPos.y;
                PhotonNetwork.Instantiate(towerselect.CurrentTower(), Camera.main.ScreenToWorldPoint(TouchPos), Quaternion.identity, 0);
                limit++;
                limitmsg.text = "You have " + (towerlimit - limit) + " left";
            }
            else
            {
                limitmsg.text = "Limit of towers has been reached";
            }
            // Just instantiates a rook tower where the touch was
        }
        if (Input.GetKeyDown("l"))
        {

                PhotonNetwork.Instantiate(towerselect.CurrentTower(), new Vector3(40, 0, 0), Quaternion.identity, 0);
                
        
   
        }
    }
}