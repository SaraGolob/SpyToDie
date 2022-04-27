using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    public void CreateRoom()//create room
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }
    public void JoinRoom()//join room
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }
    public override void OnJoinedRoom()//will be automaticaly called when connected
    {
        PhotonNetwork.LoadLevel("Game");//load a special scene //add onclick event on scene
    }

}

