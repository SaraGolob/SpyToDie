using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public Slider loader;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        if(PhotonNetwork.IsConnected == true)
        {
            loader.value = 1;
        }
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()//Automatically goes through if connected to master
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("RoomCreation");
    }
}
