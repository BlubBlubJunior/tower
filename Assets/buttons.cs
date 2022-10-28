using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene("game 1");
    }
    public void gameover()
    {
        SceneManager.LoadScene("startscreen");
    }

    
}
