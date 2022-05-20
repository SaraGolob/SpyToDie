using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitingRoomManager : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            SceneManager.LoadScene("MultiplayerMainScene");
        }
        
    }
}
