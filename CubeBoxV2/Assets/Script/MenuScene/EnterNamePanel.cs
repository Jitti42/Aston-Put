using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;

public class EnterNamePanel : MonoBehaviour
{
    public GameObject namePanel;
    public InputField inputField;
    public string character;

    public void close()
    {
        namePanel.SetActive(false);
        character = inputField.text;
        Debug.Log(character);
    }
}
