using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Rifle
{
	public override void Fire()
	{
		StartCoroutine(shoot());
	}

	private IEnumerator shoot()
	{
		if(allowFire)
		{
			allowFire = false;
			float delta = 25;
			for (int i = 0; i < 5; i++)
			{
				GameObject b1 = Instantiate(ammo, transform.position, transform.rotation);
				b1.transform.Rotate(0, delta, 0);
				delta -= 12.5f;
				b1.transform.SetParent(transform.parent.parent);
				MoveToLocalPositionOnOtherBoard(b1);
			}
			yield return new WaitForSeconds(fireRate);
			allowFire = true;
		}

	}
}
