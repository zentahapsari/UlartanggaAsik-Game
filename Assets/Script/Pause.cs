using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isGamepaused = false;
    

    // Update is called once per frame
    [SerializeField] GameObject pauseMenu;
    

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void Update()
    {

    }
    
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamepaused = false;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);

        Time.timeScale = 0f;
        isGamepaused = true;
    }

    public void Reload()
    {
        SceneManager.LoadScene("HalamanGame");
        Time.timeScale = 1f;
        isGamepaused = false;
    }
    
    public void Home()
    {
        SceneManager.LoadScene("HalamanMenu");
        Time.timeScale = 1f;
        isGamepaused = false;
        
    }
}
