using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {

    [SerializeField] private  Button []TSelectTowers;

    public Button getButton(int buttonpos)
    {
        return TSelectTowers[buttonpos];
    }
}
