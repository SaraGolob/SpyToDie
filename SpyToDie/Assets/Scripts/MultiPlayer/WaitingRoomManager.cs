using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitingRoomManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text roomName;
    private int maxPlayerCount = 2;
    private void Start()
    {
        roomName.text = PhotonNetwork.CurrentRoom.Name;
    }
    void FixedUpdate()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == maxPlayerCount)
        {            
            SceneManager.LoadScene("MultiplayerMainScene");
        }        
    } 
}
