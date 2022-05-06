using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomItem : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text roomName;
    LobbyManager manaager;
    private void Start()
    {
        manaager = FindObjectOfType<LobbyManager>();
    }
    public void SetRoomName(string sentRoomName)
    {
        roomName.text = sentRoomName;
    }
    public void OnClickItem()
    {
        manaager.JoinRoom(roomName.text);
    }
}
