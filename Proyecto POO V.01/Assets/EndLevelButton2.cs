using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelButton2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
     if(collision.gameObject.tag == "Player")
      {  
        Application.LoadLevel("Nivel 3");

      } 
    }
}
