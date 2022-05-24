using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool HasWon { get; set; }  
   
 
    private void Start()
    {
        HasWon = false;

    }
    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.CurrentRoom.MaxPlayers>2)
        {
            HasWon = true;
        }
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

        if (HasWon)
        {
            SceneChange.hasFinished = true;
            SceneManager.LoadScene("EndScreen");
        }
    }

}
