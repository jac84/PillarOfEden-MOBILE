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
    private TowerManager []towerlist = new TowerManager[4];
    void Start()
    {
        towerlist[0] = new TowerManager("CannonTower", 150);

        towerlist[1] = new TowerManager("knightTower",200);

        towerlist[2] = new TowerManager( "SmiteTower",500);

        towerlist[3] = new TowerManager("SentryTower",100);
        
    }

    public string CurrentTower()
    {
        return towerlist[GetComponent<Dropdown>().value].towerName;
    }

    public int CurrentTowercost()
    {
        return towerlist[GetComponent<Dropdown>().value].currency;
    }

    public void SpawnTower(Vector3 TouchPos, string Tower)
    {
        TouchPos.z = TouchPos.y;
        PhotonNetwork.Instantiate(Tower, Camera.main.ScreenToWorldPoint(TouchPos), Quaternion.identity, 0);
    }
}