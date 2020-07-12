using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    private static GameObject player1MoveText, player2MoveText;
    private static GameObject quiz1,PanelQuiz,timerText,gbrTimer,music,dice,timerDadu;
    private static GameObject soal1,soal2,soal3,soal4,soal5;
    private static GameObject soal6,soal7,soal8,soal9,soal10;
    // private static GameObject a1,b1,c1;
    private static GameObject player1, player2,whoWinsTextShadow;
    private static GameObject btnKick,txtKick,reset;
    
    private static GameObject HomeGO,bgGO;
    //Soal 1
    private static GameObject btnQuiz1,btnQuiz2,btnQuiz3;

    //Soal 2
    private static GameObject A2,B2,C2;
    //Soal 3
    private static GameObject A3,B3,C3;
    //Soal 4
    private static GameObject A4,B4,C4;
    //Soal 5
    private static GameObject A5,B5,C5;
    //Soal 6
    private static GameObject A6,B6,C6;
    //Soal 7
    private static GameObject A7,B7,C7;
    //Soal 8
    private static GameObject A8,B8,C8;
    //Soal 9
    private static GameObject A9,B9,C9;
    //Soal 10
    private static GameObject A10,B10,C10;
    
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
    public static bool isGamepaused = false;



    // Use this for initialization
    void Start () {
        //KUIS OBJECT
        PanelQuiz = GameObject.Find("BestScoreBackground");
        timerText = GameObject.Find("Timer");
        timerDadu = GameObject.Find("TimerDadu");
        gbrTimer = GameObject.Find("gbrTimer");
        quiz1 = GameObject.Find("quiz1");
        btnQuiz1 = GameObject.Find("btnQuiz1");
        btnQuiz2 = GameObject.Find("btnQuiz2");
        btnQuiz3 = GameObject.Find("btnQuiz3");
        A2 = GameObject.Find("A2");
        B2 = GameObject.Find("B2");
        C2 = GameObject.Find("C2");
        A3 = GameObject.Find("A3");
        B3 = GameObject.Find("B3");
        C3 = GameObject.Find("C3");
        A4 = GameObject.Find("A4");
        B4 = GameObject.Find("B4");
        C4 = GameObject.Find("C4");
        A5 = GameObject.Find("A5");
        B5 = GameObject.Find("B5");
        C5 = GameObject.Find("C5");
        A6 = GameObject.Find("A6");
        B6 = GameObject.Find("B6");
        C6 = GameObject.Find("C6");
        A7 = GameObject.Find("A7");
        B7 = GameObject.Find("B7");
        C7 = GameObject.Find("C7");
        A8 = GameObject.Find("A8");
        B8 = GameObject.Find("B8");
        C8 = GameObject.Find("C8");
        A9 = GameObject.Find("A9");
        B9 = GameObject.Find("B9");
        C9 = GameObject.Find("C9");
        A10 = GameObject.Find("A10");
        B10 = GameObject.Find("B10");
        C10 = GameObject.Find("C10");

        music = GameObject.Find("music");
        dice = GameObject.Find("Dice");

        //SOAL KUIS
        //KUIS1
        soal1 = GameObject.Find("soal1");
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        btnQuiz3.gameObject.SetActive(false);
        soal2 = GameObject.Find("soal2");
        A2.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        soal3 = GameObject.Find("soal3");
        A3.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        C3.gameObject.SetActive(false);
        soal4 = GameObject.Find("soal4");
        A4.gameObject.SetActive(false);
        B4.gameObject.SetActive(false);
        C4.gameObject.SetActive(false);
        soal5 = GameObject.Find("soal5");  
        A5.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        C5.gameObject.SetActive(false);
        soal6 = GameObject.Find("soal6");
        A6.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        C6.gameObject.SetActive(false);
        soal7 = GameObject.Find("soal7");
        A7.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        C7.gameObject.SetActive(false);
        soal8 = GameObject.Find("soal8");
        A8.gameObject.SetActive(false);
        B8.gameObject.SetActive(false);
        C8.gameObject.SetActive(false);
        soal9 = GameObject.Find("soal9");
        A9.gameObject.SetActive(false);
        B9.gameObject.SetActive(false);
        C9.gameObject.SetActive(false);
        soal10 = GameObject.Find("soal10");
        A10.gameObject.SetActive(false);
        B10.gameObject.SetActive(false);
        C10.gameObject.SetActive(false);

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        HomeGO = GameObject.Find("HomeButtonGO");
        bgGO = GameObject.Find("bgGO");
        reset = GameObject.Find("reset");

        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");
        btnKick = GameObject.Find("btnKick");
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        

        //PANEL KUIS
        PanelQuiz.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        gbrTimer.gameObject.SetActive(false);
        quiz1.gameObject.SetActive(false);
        music.gameObject.SetActive(false);
        dice.gameObject.SetActive(true);
        timerDadu.gameObject.SetActive(false);
        
        //SOAL KUIZ
        soal1.gameObject.SetActive(false);
        soal2.gameObject.SetActive(false);
        soal3.gameObject.SetActive(false);
        soal4.gameObject.SetActive(false);
        soal5.gameObject.SetActive(false);
        soal6.gameObject.SetActive(false);
        soal7.gameObject.SetActive(false);
        soal8.gameObject.SetActive(false);
        soal9.gameObject.SetActive(false);
        soal10.gameObject.SetActive(false);

        whoWinsTextShadow.gameObject.SetActive(false);
        HomeGO.gameObject.SetActive(false);
        bgGO.gameObject.SetActive(false);
        reset.gameObject.SetActive(false);


        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        btnKick.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
    }
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
                timerDadu.gameObject.SetActive(true);
                timerDadu.GetComponent<Text>().text= counter.ToString();
                gbrTimer.gameObject.SetActive(true);
                PanelQuiz.gameObject.SetActive(true);
                quiz1.gameObject.SetActive(true);
                quiz1.GetComponent<Text>().text = "Quiz 1";
                btnQuiz1.gameObject.SetActive(true);
                btnQuiz2.gameObject.SetActive(true);
                btnQuiz3.gameObject.SetActive(true);
                soal1.gameObject.SetActive(true);
                soal1.GetComponent<Text>().text = "Sungai terpanjang di Indonesia.....  A.Musi  B.Bengawan  Solo C.Kapuas";
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
                A2.gameObject.SetActive(true);
                B2.gameObject.SetActive(true);
                C2.gameObject.SetActive(true);
                soal2.gameObject.SetActive(true);
                soal2.GetComponent<Text>().text = "Daerah perlindungan untuk tumbuhan... A.Suaka Margasatwa  B.Hutan Lindung  C.Cagar Alam";
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
                A3.gameObject.SetActive(true);
                B3.gameObject.SetActive(true);
                C3.gameObject.SetActive(true);
                soal3.gameObject.SetActive(true);
                soal3.GetComponent<Text>().text = "Contoh lagu daerah Papua...         A.Poco-Poco  B.Rek Ayo Rek  C.Apuse";
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
                A4.gameObject.SetActive(true);
                B4.gameObject.SetActive(true);
                C4.gameObject.SetActive(true);
                soal4.gameObject.SetActive(true);
                soal4.GetComponent<Text>().text = "Jumlah pulau di Indonesia...  A.16.056  B.17.491  C.18.306";
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
                A5.gameObject.SetActive(true);
                B5.gameObject.SetActive(true);
                C5.gameObject.SetActive(true);
                soal5.gameObject.SetActive(true);
                soal5.GetComponent<Text>().text = "Lir Ilir, Gundhul Pacul lagu daerah provinsi..."+
                "A.Jawa Tengah  B.Jawa Timur  C.DI Yogyakarta";
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
                A6.gameObject.SetActive(true);
                B6.gameObject.SetActive(true);
                C6.gameObject.SetActive(true);
                soal6.gameObject.SetActive(true);
                soal6.GetComponent<Text>().text = "Jumlah Provinsi di Indonesia... A.30  B.32  C.34";
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
                A7.gameObject.SetActive(true);
                B7.gameObject.SetActive(true);
                C7.gameObject.SetActive(true);
                soal7.gameObject.SetActive(true);
                soal7.GetComponent<Text>().text = "Dasar negara Indonesia adalah... A.Pancasila B.UUD1945 C.Keputusan Presiden";
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
                A8.gameObject.SetActive(true);
                B8.gameObject.SetActive(true);
                C8.gameObject.SetActive(true);
                soal8.gameObject.SetActive(true);
                soal8.GetComponent<Text>().text = "Sila ketiga Pancasila dilambangkan...  A.Rantai  B.Pohon Beringin  C.Padi dan Kapas";
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
                A9.gameObject.SetActive(true);
                B9.gameObject.SetActive(true);
                C9.gameObject.SetActive(true);
                soal9.gameObject.SetActive(true);
                soal9.GetComponent<Text>().text = "Jumlah suku di Indonesia... A.1.340  B.1.500  C.1210";
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
                A10.gameObject.SetActive(true);
                B10.gameObject.SetActive(true);
                C10.gameObject.SetActive(true);
                soal10.gameObject.SetActive(true);
                soal10.GetComponent<Text>().text = "Gamelan adalah alat musik... A.Maluku  B.Jawa  C.Jambi";
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

         if (player1.GetComponent<FollowThePath>().waypointIndex == 
        player2.GetComponent<FollowThePath>().waypointIndex)
        {
            
            // KickPlayer();
        }

    //WINNER
        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            // SceneManager.LoadScene("HalamanGO");
            // HomeGO.gameObject.SetActive(true);
            bgGO.gameObject.SetActive(true);
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            // PanelQuiz.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            player1StartWaypoint=0;
            // gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            // SceneManager.LoadScene("HalamanGO");
            // HomeGO.gameObject.SetActive(true);
            bgGO.gameObject.SetActive(true);
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            // dice.gameObject.SetActive(false);
            // PanelQuiz.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            player2StartWaypoint=0;
            // gameOver = true;
        }
    }

        public void HomeGo()
    {
        SceneManager.LoadScene("HalamanMenu");
        
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
    
    IEnumerator hitungmundur(){
        while(counter>0){
        yield return new WaitForSeconds(1);
        dice.gameObject.SetActive(false);
        counter -= 1;
        myFX.PlayOneShot (countdown);
        timerDadu.GetComponent<Text>().text= counter.ToString();
        timerText.GetComponent<Text>().text= counter.ToString();
        }
        yield return new WaitForSeconds(1);
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        btnQuiz3.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        timerDadu.gameObject.SetActive(false);
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
        soal6.gameObject.SetActive(false);
        soal7.gameObject.SetActive(false);
        soal8.gameObject.SetActive(false);
        soal9.gameObject.SetActive(false);
        soal10.gameObject.SetActive(false);
        A2.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        A3.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        C3.gameObject.SetActive(false);
        A4.gameObject.SetActive(false);
        B4.gameObject.SetActive(false);
        C4.gameObject.SetActive(false);
        A5.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        C5.gameObject.SetActive(false);
        A6.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        C6.gameObject.SetActive(false);
        A7.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        C7.gameObject.SetActive(false);
        A8.gameObject.SetActive(false);
        B8.gameObject.SetActive(false);
        C8.gameObject.SetActive(false);
        A9.gameObject.SetActive(false);
        B9.gameObject.SetActive(false);
        C9.gameObject.SetActive(false);
        A10.gameObject.SetActive(false);
        B10.gameObject.SetActive(false);
        C10.gameObject.SetActive(false);

        counter=10;
        
    }


    public void KickBtn()
    {
        
        // dice.gameObject.SetActive(true);
        // btnKick.gameObject.SetActive(false);

        
    }

    
    public void btnBenar()
    
    {
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        // btnQuiz3.gameObject.SetActive(false);
        A2.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        // C2.gameObject.SetActive(false);
        A3.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        // C3.gameObject.SetActive(false);
        A4.gameObject.SetActive(false);
        // B4.gameObject.SetActive(false);
        C4.gameObject.SetActive(false);
        // A5.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        C5.gameObject.SetActive(false);
        A6.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        // C6.gameObject.SetActive(false);
        // A7.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        C7.gameObject.SetActive(false);
        A8.gameObject.SetActive(false);
        // B8.gameObject.SetActive(false);
        C8.gameObject.SetActive(false);
        // A9.gameObject.SetActive(false);
        B9.gameObject.SetActive(false);
        C9.gameObject.SetActive(false);
        A10.gameObject.SetActive(false);
        // B10.gameObject.SetActive(false);
        C10.gameObject.SetActive(false);
        quiz1.GetComponent<Text>().text = "BENAR!";
        soal1.GetComponent<Text>().text = "Sungai Kapuas Adalah sungai terpanjang di Indonesia, yang berada di Kalimantan Barat";
        soal2.GetComponent<Text>().text = "Suaka Margasatwa untuk perlindungan hewan, hutan lindung untuk pelestarian keanekaragaman makhluk hidup ";
        soal3.GetComponent<Text>().text = "Lagu Poco-Poco dari daerah Maluku dan Rek Ayo Rek dari Surabaya";
        soal4.GetComponent<Text>().text = "Terdapat 17.491 pulau di Indonesia menurut Kementerian Koordinator Bidang Kemaritiman dan Investasi RI";
        soal5.GetComponent<Text>().text = "Lagu daerah Lir Ilir, Gundul Pacul, Gambang Suling berasal dari Jawa Tengah";
        soal6.GetComponent<Text>().text = "Terdapat 34 provinsi di Indonesia menurut kementrian dalam negeri / KEMENDAGRI";
        soal7.GetComponent<Text>().text = "Pancasila resmi disahkan sebagai dasar negara pada 22 juni 1945";
        soal8.GetComponent<Text>().text = "Melambangkan tempat berteduh dan berlindung dengan akar tunjang mencerminkan persatuan dan kesatuan";
        soal9.GetComponent<Text>().text = "Terdapat 1.340 suku di Indonesia menurut sensus BPS tahun 2010";
        soal10.GetComponent<Text>().text = "Gamelan merupakan alat musik khas Jawa, Sunda, dan Bali";
        

        
    }
        public void btnSalah()
    
    {
        quiz1.GetComponent<Text>().text = "Salah!";
        btnQuiz1.gameObject.SetActive(false);
        btnQuiz2.gameObject.SetActive(false);
        btnQuiz3.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        timerDadu.gameObject.SetActive(true);
        gbrTimer.gameObject.SetActive(false);
        PanelQuiz.gameObject.SetActive(false);
        quiz1.gameObject.SetActive(false);
        music.gameObject.SetActive(false);
        // dice.gameObject.SetActive(true);
        soal1.gameObject.SetActive(false);
        soal2.gameObject.SetActive(false);
        soal3.gameObject.SetActive(false);
        soal4.gameObject.SetActive(false);
        soal5.gameObject.SetActive(false);
        soal6.gameObject.SetActive(false);
        soal7.gameObject.SetActive(false);
        soal8.gameObject.SetActive(false);
        soal9.gameObject.SetActive(false);
        soal10.gameObject.SetActive(false);
        A2.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        A3.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        C3.gameObject.SetActive(false);
        A4.gameObject.SetActive(false);
        B4.gameObject.SetActive(false);
        C4.gameObject.SetActive(false);
        A5.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        C5.gameObject.SetActive(false);
        A6.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        C6.gameObject.SetActive(false);
        A7.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        C7.gameObject.SetActive(false);
        A8.gameObject.SetActive(false);
        B8.gameObject.SetActive(false);
        C8.gameObject.SetActive(false);
        A9.gameObject.SetActive(false);
        B9.gameObject.SetActive(false);
        C9.gameObject.SetActive(false);
        A10.gameObject.SetActive(false);
        B10.gameObject.SetActive(false);
        C10.gameObject.SetActive(false);

         if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint)
        {
            if(player1StartWaypoint == 3){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[0].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 0;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint == 26){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[23].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 23;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint == 39){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 36;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint == 55){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 52;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint == 64){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[61].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 61;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        
        if (player2.GetComponent<FollowThePath>().waypointIndex > 
            player2StartWaypoint)
        {
            if(player2StartWaypoint== 3){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[0].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 0;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint== 26){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[23].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 23;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint== 39){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 36;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint== 55){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 52;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint== 64){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[61].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 61;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            player2.GetComponent<FollowThePath>().moveAllowed = false;            
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        
    }
}
