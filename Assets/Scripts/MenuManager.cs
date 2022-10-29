using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    
    public int highScore;
    public string highScoreName;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = $"Best Score: {highScoreName}: {highScore}" ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewNameEnter(string name)
    {
        ScoreManager.instance.playerName = name;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
