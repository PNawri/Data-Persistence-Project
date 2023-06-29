using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public static MenuUI Instance;
    public TMPro.TMP_InputField inputName;
    public string playerName;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
        

    public void StartNew()
    {
        playerName = inputName.text;
        SceneManager.LoadScene(1);
    }
}