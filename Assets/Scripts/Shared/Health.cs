using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
	[SerializeField] int maxHP;
	int currentHP;

	public virtual void Start()
	{
		currentHP = maxHP;
	}
	public void TakeDamage(int damage = 0)
	{
		currentHP -= damage;
		CheckIfStillAlive();
	}

	public void CheckIfStillAlive()
	{
		if(currentHP <= 0)
		{
			currentHP = 0;
			Die();
		}
	}
	public abstract void Die();
}
