using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
   
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public AudioSource m_MyAudioSource ;
     //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    void Update()
    {
       
        if(Input.GetButtonDown("Fire1"))
        {   
            Shoot();
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

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        
    }

   
}
