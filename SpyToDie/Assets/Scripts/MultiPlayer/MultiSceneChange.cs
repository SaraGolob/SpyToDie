using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    private int maxPlayerCount = 2;
    
 

    // Update is called once per frame
    void Update()
    {        
        LooseCondition();
        WinCondition();
    }
    public void LooseCondition()
    {
        if (Timer.currentTime <= 0)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
    public void WinCondition()
    {
        //win check
        if (PhotonNetwork.CurrentRoom.MaxPlayers > maxPlayerCount)
        {
            SceneChange.hasFinished = true;
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("EndScreen");
        }
    }
}
