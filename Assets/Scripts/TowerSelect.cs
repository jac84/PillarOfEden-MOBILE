using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TowerSelect : MonoBehaviour {
    [SerializeField] private string[] Towers;
    [SerializeField] private int currentTower;
    [SerializeField] private Text ButtonTower;
	// Use this for initialization
    void Start()
    {
        ButtonTower.text = Towers[currentTower];
    }

    public void TowerSwitch()
    {
        for(int i = 0; i < Towers.Length; i++)
        {
            if (currentTower == i)
            {
                if ((currentTower + 2) > Towers.Length)
                {
                    currentTower = 0;
                    ButtonTower.text = Towers[currentTower];
                    return;
                }
                else
                {
                    currentTower++;
                    ButtonTower.text = Towers[currentTower];
                    return;
                }
            }
        }
    }
    public string CurrentTower()
    {
        return Towers[currentTower];
    }
}
