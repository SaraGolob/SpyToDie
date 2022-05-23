using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
   
    public TMP_InputField roomInputField;
 
    public Text roomName;

    public RoomItem roomItemPrefabs;
    List<RoomItem> roomItemsList = new List<RoomItem>();
    public Transform contentObject;
    public UnityEvent errorMessageDuplicate, errorMessageLength;
    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }
    public void OnClickCreate()
    {
        PhotonNetwork.NickName = "Player1";
        if (roomInputField.text.Length >= 1 && roomInputField.text.Length <=10)
        {
            PhotonNetwork.CreateRoom(roomInputField.text, new RoomOptions() { MaxPlayers = 2 });
        }
        else
        {
            errorMessageLength.Invoke();
        }
        for (int i = 0; i < roomItemsList.Count; i++)
        {
            if ( roomInputField.text == roomItemsList[i].roomName.text )
            {
                errorMessageDuplicate.Invoke();
            }
        }
        
    }
    
    public override void OnJoinedRoom()
    {        
        roomInputField.text = PhotonNetwork.CurrentRoom.Name;
    }
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        UpdateRoomList(roomList);
    }
    public void UpdateRoomList(List<RoomInfo> list)
    {
        foreach (RoomItem item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();

        foreach(RoomInfo room in list)
        {
            if (room.PlayerCount < 2)
            {
                RoomItem newRoom = Instantiate(roomItemPrefabs, contentObject);
                newRoom.SetRoomName(room.Name);
                roomItemsList.Add(newRoom);
            }
        }
    }
    public void JoinRoom(string roomName)
    {        
        PhotonNetwork.JoinRoom(roomName);
        PhotonNetwork.NickName = "Player2";
    }
}
