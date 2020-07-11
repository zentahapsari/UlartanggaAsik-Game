using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResetScript : MonoBehaviour
{
    
    void Start(){
        RestartGame();
    }
    public void RestartGame()
    {
    GameControl.diceSideThrown = 0; 
    }

}
