using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisconnectPlayers : MonoBehaviour
{
   
    private int maxPlayerCount = 2;

    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount != maxPlayerCount)
        {            
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("MainMenu");
        }
    }
}
