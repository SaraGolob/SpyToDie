using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PasswordScript : MonoBehaviour
{
    public Text password;

    public string correctPassword;

    public UnityEvent simpleEvent;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                CheckPassword();
            }
            else if (Input.GetKeyDown(KeyCode.Backspace) && password.text.Length > 0)
            {
                Backspace();
            }
            else if (password.text.Length < 15)
            {
                password.text += Input.inputString;
            }
        }
    }

    public void Backspace()
    {
        password.text = password.text.Remove(password.text.Length - 1);
    }

    public void CheckPassword()
    {
        if (password.text == correctPassword)
        {
            simpleEvent.Invoke();
            SceneManager.LoadScene("EndScreen");
        }
        else
        {
            password.text = "";
        }
    }
}
