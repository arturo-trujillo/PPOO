using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public Text scoreText ;
    bool timerReached = false;
    float timer = 0 ;
    public int ScoreC;
    void Update()
    {
         if(!timerReached){
            timer +=Time.deltaTime;
        }
        if(!timerReached && timer > 2){
            ScoreC = ScoreC + 10; 
            scoreText.text = ScoreC.ToString();
            timer= 0;
            

        }
    }
}
