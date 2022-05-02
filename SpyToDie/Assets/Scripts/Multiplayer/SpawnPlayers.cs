using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    public static Transform playerTrans;
    public Text text;
    //Coordinates on where you can spawn on a specific place

    private void Start()
    {
        Vector3 randomPos = new Vector3(0,0,0);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
        text.text = TransferableVariabels.ID;
        playerTrans = playerPrefab.transform;
    }
}
