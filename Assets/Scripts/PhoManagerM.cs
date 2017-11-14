using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoManagerM : Photon.MonoBehaviour
{
    public Text connectstatus;
    void Start()
    {
        
        PhotonNetwork.ConnectUsingSettings("test");
        //Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());
    }

    public virtual void OnJoinedLobby()
    {
        RoomOptions roomops = new RoomOptions() { isVisible = true, MaxPlayers = 2 };
        PhotonNetwork.JoinOrCreateRoom("hello", roomops, TypedLobby.Default);

    }
    void Update()
    {
        //connectstatus.text = PhotonNetwork.connectionStateDetailed.ToString();
        Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());
    }


}
