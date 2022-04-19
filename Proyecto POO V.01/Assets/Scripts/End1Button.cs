using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End1Button : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision){
     if(collision.gameObject.tag == "Player")
      {  
        Application.LoadLevel("Final1");

      } 
    }
}
