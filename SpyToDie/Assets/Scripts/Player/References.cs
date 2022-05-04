using UnityEngine;

public class References : MonoBehaviour
{
    public Transform playerTransform;
    public static References instance;

    public Player_Movement playerMovement;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }
    }
}
