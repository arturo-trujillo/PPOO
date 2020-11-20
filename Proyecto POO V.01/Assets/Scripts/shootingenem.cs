using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingenem : MonoBehaviour
{


    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
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
        if(!timerReached && timer > 4){
            Shoot(); 
            timer= 0;
            

        }
        
      
    }

     void Shoot()
    {
        
        GameObject EnemyBullet1 = Instantiate(bulletEnemyPrefab, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rb1 = EnemyBullet1.GetComponent<Rigidbody2D>();
        rb1.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);

        GameObject EnemyBullet2 = Instantiate(bulletEnemyPrefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb2 = EnemyBullet2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
        
        GameObject EnemyBullet3 = Instantiate(bulletEnemyPrefab, firePoint3.position, firePoint3.rotation);
        Rigidbody2D rb3 = EnemyBullet3.GetComponent<Rigidbody2D>();
        rb3.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
        
        GameObject EnemyBullet4 = Instantiate(bulletEnemyPrefab, firePoint4.position, firePoint4.rotation);
        Rigidbody2D rb4 = EnemyBullet4.GetComponent<Rigidbody2D>();
        rb4.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
        
        
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
