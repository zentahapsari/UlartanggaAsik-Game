using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    public AudioSource myFX;
    public AudioClip suaraDadu1,suaraDadu2,suaraDadu3,suaraDadu4,suaraDadu5,suaraDadu6;


	// Use this for initialization
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
	}

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
            GetComponent<AudioSource>().Play();
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
         switch (GameControl.nofPlayers)
        {
            case 1:
                whosTurn =1;
                GameControl.MovePlayer(1);
                break;
            case 2: // Dadu 6, Player 2 kali move
               if (randomDiceSide == 4)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu5);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu5);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                } if (randomDiceSide == 3)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu4);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu4);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                } if (randomDiceSide == 2)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu3);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu3);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                } if (randomDiceSide == 1)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu2);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu2);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                } if (randomDiceSide == 0)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu1);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu1);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                }  if (randomDiceSide == 5)
                {
                    
                    if (whosTurn == 1)
                    {
                        myFX.PlayOneShot (suaraDadu6);
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                        
                    }
                    else if (whosTurn == 2)
                    {
                        myFX.PlayOneShot (suaraDadu6);
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                        
                    }
                    coroutineAllowed = true;
                } 
                else
                { // Player move biasa
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 1;
                        GameControl.MovePlayer(2);

                    }
                }
                break;

           

    }         coroutineAllowed = true;

   }
}

