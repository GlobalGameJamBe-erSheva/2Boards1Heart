using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour, IWeapon
{
	[field: SerializeField] public GameObject ammo { get; set; }

	public void Fire()
	{
		Vector3 pos;
		pos = transform.Find("Bullet Spawn").position;
		Instantiate<GameObject>(ammo, pos, transform.rotation);
	}

	public Vector3 LocateSpawnPositionOnOtherBoard()
	{
		throw new System.NotImplementedException();
	}
}
