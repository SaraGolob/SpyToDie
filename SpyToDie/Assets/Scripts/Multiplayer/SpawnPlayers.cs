using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    public Text text;
    //Coordinates on where you can spawn on a specific place
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        Vector2 randomPos = new Vector2(70,70);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
        text.text = TransferableVariabels.ID;
    }
}
