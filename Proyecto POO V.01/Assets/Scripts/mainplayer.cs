using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainplayer : MonoBehaviour
{
  public int health = 100;
  public int damage= 30 ;

	public GameObject deathEffect;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
