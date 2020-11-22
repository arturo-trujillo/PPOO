using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingenem2 : MonoBehaviour
{
  public Transform firePoint1;
    public GameObject bulletEnemyPrefab;
    public float bulletForce = 20f;
    public AudioSource m_MyAudioSource ;
    bool m_Play;
    bool m_ToggleChange;
    bool timerReached = false;
    float timer =0;
    
    

    void Start()
    { 
        m_MyAudioSource = GetComponent<AudioSource>();
        m_Play = true;
    }

    void Update()
    {
        
        if(!timerReached){
            timer +=Time.deltaTime;
        }
        if(!timerReached && timer > .6){
            Shoot(); 
            timer= 0;
            

        }
        
      
    }

     void Shoot()
    {
        
        GameObject EnemyBullet1 = Instantiate(bulletEnemyPrefab, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rb1 = EnemyBullet1.GetComponent<Rigidbody2D>();
        rb1.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
        
        
         if (m_Play == true && m_ToggleChange == true)
            {
            m_MyAudioSource.Play();
            m_ToggleChange = false;
            }
       
        if (m_Play == false && m_ToggleChange == true)
            {
            m_MyAudioSource.Stop();
            m_ToggleChange = false;
            }
    }
}
