using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
	Player player;
	[SerializeField] GameObject rifle;
	IWeapon weapon;

	public void InitSelf()
	{
		player = GetComponent<Player>();
		////Object prefab = Resources.Load("Weapons/Rifle/Rifle");
		GameObject obj = Instantiate(rifle, transform.position + new Vector3(0, 0, 1f), Quaternion.identity);
		obj.transform.SetParent(transform);
		weapon = obj.GetComponent<Rifle>() as IWeapon;
	}
	private void Update()
	{
		if (player.IsAttacking())
		{
			weapon.Fire();
		}
	}
}
