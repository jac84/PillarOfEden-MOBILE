using UnityEngine;
using System.Collections;

public class WatcherScript : Photon.MonoBehaviour
{
    [SerializeField]
    private string[] myTowers;
    [SerializeField]
    TowerSelect towerselect;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 TouchPos = Input.GetTouch(0).position;
            TouchPos.z = TouchPos.y;
            PhotonNetwork.Instantiate(towerselect.CurrentTower(), Camera.main.ScreenToWorldPoint(TouchPos), Quaternion.identity, 0);
            // Just instantiates a rook tower where the touch was
        }
        if (Input.GetKeyDown("l"))
        {
            PhotonNetwork.Instantiate(towerselect.CurrentTower(), new Vector3(30, 0, 0), Quaternion.identity, 0);
        }
    }
}