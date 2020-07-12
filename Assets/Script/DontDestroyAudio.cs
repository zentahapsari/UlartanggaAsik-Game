using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontDestroyAudio : MonoBehaviour
{
      public GameObject music;

    // Start is called before the first frame update
    void Awake()
    {
 
        DontDestroyOnLoad (music);
 
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
 
    void OnSceneLoaded (Scene scene, LoadSceneMode mode)
    {
        if((scene.buildIndex != 0) && (scene.buildIndex != 1))
        {
            Destroy(music);
        }
    }
}
