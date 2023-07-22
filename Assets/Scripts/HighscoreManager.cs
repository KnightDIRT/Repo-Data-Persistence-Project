using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreManager : MonoBehaviour
{
    private Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        SharedManager.Instance.LoadHighscore();
        highscoreText = GameObject.Find("Highscore").GetComponent<Text>();
        string highscoreName = SharedManager.Instance.highscoreName;
        int highscore = SharedManager.Instance.highscore;
        highscoreText.text = string.Format("Highscore : {0} : {1}", highscoreName, highscore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
