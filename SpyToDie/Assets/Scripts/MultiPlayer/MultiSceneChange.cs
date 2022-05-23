using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    private int hasWon;   
    public static ExitGames.Client.Photon.Hashtable customProperties = new ExitGames.Client.Photon.Hashtable();
 
    private void Start()
    {
        PhotonNetwork.CurrentRoom.SetCustomProperties(customProperties);   
        customProperties.Add(hasWon, 0);
    }
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
        Debug.Log(customProperties);
        //if((int)customProperties["HasWon"]==1)
        //{
        //    SceneChange.hasFinished = true;
        //    SceneManager.LoadScene("EndScreen");
        //}
    }

}
