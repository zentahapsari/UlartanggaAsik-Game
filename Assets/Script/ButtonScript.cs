using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject menuPanel;

    void Start(){
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(SceneManager.GetActiveScene().name == "HalamanMenu"){
                exitPanel.SetActive(true);
            }
            else{
                // AdmobScript.instance.showInterstitialAd();
                menuPanel.SetActive(true);
            }
        }
    }
    public void CancelBtn(){
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("HalamanMenu");
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ResetBtn()
    {
        SceneManager.LoadScene("HalamanGame");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

}
