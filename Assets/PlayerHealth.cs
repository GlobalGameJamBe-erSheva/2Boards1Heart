using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
	Player player;

	public override void Start()
	{
		base.Start();
		player = GetComponent<Player>();
	}
	public override void Die()
	{
		player.Die();
	}
}
