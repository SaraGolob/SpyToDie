using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject IDObject;
    public GameObject Player1;
    public GameObject Player2;
    public static Transform playerTrans;
    public Text text;
    //Coordinates on where you can spawn on a specific place

    private void Start()
    {        
        PhotonNetwork.Instantiate(IDObject.name, Vector3.zero, Quaternion.identity);
        text.text = TransferableVariabels.ID;
             
        if (PhotonNetwork.NickName == "Player1")
        {
            Player1.SetActive(true);
            Player2.SetActive(false);            
        }
        else if (PhotonNetwork.NickName == "Player2")
        {
            Player1.SetActive(false);
            Player2.SetActive(true);            
        }
    }
}
