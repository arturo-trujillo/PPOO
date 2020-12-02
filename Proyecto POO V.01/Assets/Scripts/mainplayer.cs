using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(AudioSource))]
 
public class mainplayer : MonoBehaviour
{
  public int maxHealth = 100;
  public int health = 100;
  public int damage= 30 ;
  public HealthBar healthBar;
  public GameObject deathEffect;
  public int ScoreCounter;
  public int ScoreAdd = 10;

 
	void Start()
	{

		healthBar.SetMaxHealth(maxHealth);
	

	}

	public void TakeDamage (int damage)
	{
		AudioSource hit = GetComponent<AudioSource>();
		health -= damage;
		healthBar.SetHealth(health);
		hit.Play();
		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		 Application.LoadLevel("Death");
	}


}
