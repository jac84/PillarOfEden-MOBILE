using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TowerSelect : MonoBehaviour
{
    [SerializeField]
    private string[] Towers;
    [SerializeField]
    private int currentTower;
    [SerializeField]
    private Text ButtonTower;

    // Use this for initialization
    void Start()
    {
        ButtonTower.text = Towers[currentTower];
    }

    public void TowerSwitch()
    {
        Debug.Log(Towers[GetComponent<Dropdown>().value]);
    }
    public string CurrentTower()
    {
        
        return Towers[GetComponent<Dropdown>().value];
    }
}