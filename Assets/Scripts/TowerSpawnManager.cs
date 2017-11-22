using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TowerSpawnManager : Photon.MonoBehaviour
{
    public class TowerManager {
        public string towerName;
        public int currency;
        public TowerManager(string TowerName, int Currency)
        {
            towerName = TowerName;
            currency = Currency;
        }
    }
    [SerializeField] private UIManager Buttons;
    private TowerManager []towerlist = new TowerManager[4];
    private int selected;
    void Start()
    {
        towerlist[1] = new TowerManager("CannonTower", 150);

        towerlist[2] = new TowerManager("knightTower",200);

        towerlist[3] = new TowerManager( "SmiteTower",500);

        towerlist[0] = new TowerManager("SentryTower",100);
        
    }
    
    public void selectCannon()
    {
        
        selected = 1;
        Debug.Log(towerlist[selected].towerName);
    }

    public void selectKnight()
    {
        selected = 2;
        //return towerlist[GetComponent<Dropdown>().value].currency;
    }

    public void selectSmite()
    {
        selected = 3;
    }

    public void selectSentry()
    {
        selected = 0;
    }

    public string CurrentTower()
    {
        return towerlist[selected].towerName;
    }

    public int CurrentTowercost()
    {
        return towerlist[selected].currency;
    }
    public void SpawnTower(Vector3 TouchPos, string Tower)
    {
        
        TouchPos.z = TouchPos.y;
        Ray ray = Camera.main.ScreenPointToRay(TouchPos);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            if (hit.transform.tag == "U.I")
            {
                return;
            }
        }
        PhotonNetwork.Instantiate(Tower, Camera.main.ScreenToWorldPoint(TouchPos), Quaternion.identity, 0);
    }
}