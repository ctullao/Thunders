using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterData : MonoBehaviour
{
    public InputField textBox;

    public void clickEnter()
    {
        PlayerPrefs.SetString("username", textBox.text);
        SceneManager.LoadScene("SecondScene");
    }
  
}
