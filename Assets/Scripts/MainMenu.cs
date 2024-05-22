using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button play;
    public Button option;
    public Button quit;

    void Start()
    {
        play.onClick.AddListener(PlayMaze);
        play.onClick.AddListener(QuitMaze);
    }

    public void PlayMaze()
    {
        Debug.Log("yo");
        SceneManager.LoadScene("maze");
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
