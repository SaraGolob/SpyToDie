using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomItem : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text roomName;
    LobbyManager manager;
    private void Start()
    {
        manager = FindObjectOfType<LobbyManager>();
    }
    public void SetRoomName(string sentRoomName)
    {
        roomName.text = sentRoomName;
    }
    public void OnClickItem()
    {
        manager.JoinRoom(roomName.text);
    }
}
