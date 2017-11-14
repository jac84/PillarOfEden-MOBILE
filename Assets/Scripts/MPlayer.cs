using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPlayer : MonoBehaviour {
    [SerializeField] private TowerSpawnManager towermanager;
    [SerializeField] private Text CurrencyVisual;
    [SerializeField]private int PlayerCurrency;
	// Use this for initialization
	void Start () {
        CurrencyVisual.text = "Money: " + PlayerCurrency;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (PlayerCurrency > towermanager.CurrentTowercost())
            {
                towermanager.SpawnTower(Input.GetTouch(0).position, towermanager.CurrentTower());
                PlayerCurrency -= towermanager.CurrentTowercost();
                CurrencyVisual.text = "Money: " + PlayerCurrency;
            }
            else
            {
                Debug.Log("No more money boyo");
            }
        }
    }
}
