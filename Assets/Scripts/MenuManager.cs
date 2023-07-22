using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private TMP_InputField inputName;
    private Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        inputName = GameObject.Find("NameInput").GetComponent<TMP_InputField>();
        startButton = GameObject.Find("Button").GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        SharedManager.Instance.playerName = inputName.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
