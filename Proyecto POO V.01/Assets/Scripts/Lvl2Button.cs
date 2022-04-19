using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Button : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D collision){
     if(collision.gameObject.tag == "Player")
      {  
        Application.LoadLevel("Nivel 2");

      } 
    }
}
