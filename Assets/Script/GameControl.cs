using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    private static GameObject player1MoveText, player2MoveText;
    private static GameObject quiz1,PanelQuiz,btnQuiz1,btnQuiz2,btnQuiz3,timerText,gbrTimer,music,dice;
    private static GameObject soal1,soal2,soal3,soal4,soal5;
    private static GameObject player1, player2,whoWinsTextShadow;
    private static GameObject btnKick,txtKick;
    public Animator animtr;
    public Animator animtr2;


    public AudioSource myFX;
    public AudioClip countdown;
    public static int nofPlayers=2;
    public int counter = 10;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;



    // Use this for initialization
    void Start () {
        //KUIS OBJECT
        PanelQuiz = GameObject.Find("BestScoreBackground");
        timerText = GameObject.Find("Timer");
        gbrTimer = GameObject.Find("gbrTimer");
        quiz1 = GameObject.Find("quiz1");
        btnQuiz1 = GameObject.Find("btnQuiz1");
        btnQuiz2 = GameObject.Find("btnQuiz2");
        btnQuiz3 = GameObject.Find("btnQuiz3");
        music = GameObject.Find("music");
        dice = GameObject.Find("Dice");

        //SOAL KUIS
        soal1 = GameObject.Find("soal1");
        soal2 = GameObject.Find("soal2");
        soal3 = GameObject.Find("soal3");
        soal4 = GameObject.Find("soal4");
        soal5 = GameObject.Find("soal5");

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");
        btnKick = GameObject.Find("btnKick");
        txtKick = GameObject.Find("txtKick");
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        

        //PANEL KUIS
        PanelQuiz.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        gbrTimer.gameObject.SetActive(false);
        quiz1.gameObject.SetActive(false);
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        btnQuiz3.gameObject.SetActive(false);
        music.gameObject.SetActive(false);
        dice.gameObject.SetActive(true);
        
        //SOAL KUIZ
        soal1.gameObject.SetActive(false);
        soal2.gameObject.SetActive(false);
        soal3.gameObject.SetActive(false);
        soal4.gameObject.SetActive(false);
        soal5.gameObject.SetActive(false);

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        btnKick.gameObject.SetActive(false);
        txtKick.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
//Turn text
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
        }
//PLAYER 1
          if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            //Quiz
            if(player1StartWaypoint+diceSideThrown == 3){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 1";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal1.gameObject.SetActive(true);
                
                StartCoroutine(hitungmundur());
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 26){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 2";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal2.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 39){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 3";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal3.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 55){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 4";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal4.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 64){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 5";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal5.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(1);
            }
           

            //Tangga
            if(player1StartWaypoint+diceSideThrown == 4){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 24;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 20){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[37].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 37;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 56){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[61].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 61;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }

            //Ular
            if(player1StartWaypoint+diceSideThrown == 19){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[16].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 16;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 30){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[22].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 22;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 53){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[50].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 50;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 60){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 44;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }
//PLAYER 2
          if (player2.GetComponent<FollowThePath>().waypointIndex > 
            player2StartWaypoint + diceSideThrown)
        {
             //Quiz
            if(player2StartWaypoint+diceSideThrown == 3){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 1";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal1.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 26){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 2";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal2.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 39){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 3";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal3.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 55){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 4";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal4.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 64){
                music.gameObject.SetActive(true);
                timerText.gameObject.SetActive(true);
                timerText.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 5";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal5.gameObject.SetActive(true);
                StartCoroutine(hitungmundur());
                MovePlayer(2);
            }
            //Tangga
            if(player2StartWaypoint+diceSideThrown == 4){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 24;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 20){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[37].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 37;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 56){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[61].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 61;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            //Ular
            if(player2StartWaypoint+diceSideThrown == 19){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[16].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 16;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 30){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[22].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 22;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 53){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[50].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 50;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 60){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 44;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            
            player2.GetComponent<FollowThePath>().moveAllowed = false;            
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }   

//Player 1 dan 2 kotak yang sama
        
    //MENANG
        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            SceneManager.LoadScene("HalamanGO");
            // whoWinsTextShadow.gameObject.SetActive(true);
            // whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            SceneManager.LoadScene("HalamanGO");
            // whoWinsTextShadow.gameObject.SetActive(true);
            // player1MoveText.gameObject.SetActive(false);
            // player2MoveText.gameObject.SetActive(false);
            // whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
    }

    //PERPINDAHAN MAJU
    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
    
    //PERPINDAHAN MUNDUR
    public static void MundurPlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
    IEnumerator hitungmundur(){
        while(counter>0){
        yield return new WaitForSeconds(1);
        counter -= 1;
        myFX.PlayOneShot (countdown);
        dice.gameObject.SetActive(false);
        timerText.GetComponent<Text>().text= counter.ToString();
        }
        yield return new WaitForSeconds(1);
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        btnQuiz3.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        gbrTimer.gameObject.SetActive(false);
        PanelQuiz.gameObject.SetActive(false);
        quiz1.gameObject.SetActive(false);
        music.gameObject.SetActive(false);
        dice.gameObject.SetActive(true);
        soal1.gameObject.SetActive(false);
        soal2.gameObject.SetActive(false);
        soal3.gameObject.SetActive(false);
        soal4.gameObject.SetActive(false);
        soal5.gameObject.SetActive(false);
        counter=10;

    }
    public static void KickPlayer(int playerToKick){
    //    switch (playerToKick) { 
    //         case 1:
    //             player1.GetComponent<FollowThePath>().moveAllowed = true;
    //             break;

    //         case 2:
    //             player2.GetComponent<FollowThePath>().moveAllowed = true;
    //             break;
    //     }
    }
}
