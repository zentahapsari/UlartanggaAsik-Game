using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // [SerializeField]
    // GameObject objectToDestroy;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    
    // public void DestroyGameObject(){
    //     Destroy (objectToDestroy);
    // }

    void Update () {
      //  Destroy(gameObject, 2f); // Destroy Gameobject, after 2 Seconds.
 }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "music")
        {
           Destroy(gameObject); // Just destroy Gameobject, without delay.

            // Destroy(gameObject, 5f); // Destroy GameObject after 5 Seconds.
        }
    }
}
