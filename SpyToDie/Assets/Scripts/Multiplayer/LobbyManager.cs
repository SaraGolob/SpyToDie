using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public TMP_InputField roomInputField;
    //public GameObject lobbyPanel;
    //public GameObject roomPanel;
    public Text roomName;

    public RoomItem roomItemPrefabs;
    List<RoomItem> roomItemsList = new List<RoomItem>();
    public Transform contentObject;
    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }
    public void OnClickCreate()
    {
        PhotonNetwork.NickName = "Player1";
        if (roomInputField.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(roomInputField.text, new RoomOptions() { MaxPlayers = 2 });
            
        }
        
    }
    public override void OnJoinedRoom()
    {
        //lobbyPanel.SetActive(false);
        //roomPanel.SetActive(true);
        
        roomName.text = PhotonNetwork.CurrentRoom.Name;
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
            RoomItem newRoom = Instantiate(roomItemPrefabs, contentObject);
            newRoom.SetRoomName(room.Name);
            roomItemsList.Add(newRoom);
        }
    }
    public void JoinRoom(string roomName)
    {
        
        PhotonNetwork.JoinRoom(roomName);
        PhotonNetwork.NickName = "Player2";
    }
}
