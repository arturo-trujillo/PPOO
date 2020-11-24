using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelButton1 : MonoBehaviour
{
    
   void OnCollisionEnter2D(Collision2D collision){
     if(collision.gameObject.tag == "Player")
      {  
        Application.LoadLevel("Nivel 2");

      } 
    }
}
