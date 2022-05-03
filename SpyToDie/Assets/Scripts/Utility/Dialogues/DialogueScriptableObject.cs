using UnityEngine;
[CreateAssetMenu(fileName = "New_dialogue", menuName = "Dialogue")] //creates a new file from this script
public class DialogueScriptableObject : ScriptableObject
{
    //scriptable objects hold data for you - a file that you can use as an object
    public Info[] dialogueInfo;
    [System.Serializable] //makes info class seen in the inspector
    public class Info
    {
        [TextArea(4, 8)] public string dialogue; //text area makes it easier to read in the inspector
    }
}
