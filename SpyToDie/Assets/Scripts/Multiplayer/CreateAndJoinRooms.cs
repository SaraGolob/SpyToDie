using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] public TextMeshProUGUI joinInput;
    public void CreateRoom()//create room
    {
        int first = Random.Range(0, 9);
        int second = Random.Range(0, 9);
        int third = Random.Range(0, 9);
        first += second + third;
        string roomID = first.ToString();
        TransferableVariabels.ID = roomID;
        PhotonNetwork.CreateRoom(roomID);
    }
    public void JoinRoom()//join room
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }
    public override void OnJoinedRoom()//will be automaticaly called when connected
    {
        PhotonNetwork.LoadLevel("MainScene");//load a special scene //add onclick event on scene
    }

}

