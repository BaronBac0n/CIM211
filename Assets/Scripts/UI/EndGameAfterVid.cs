using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndGameAfterVid : MonoBehaviour
{
    
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    
    void Start()
    {
        VideoPlayer.loopPointReached += QuitGame;
    }
    void QuitGame(VideoPlayer vp)
    {
        Application.Quit();
    }
}

