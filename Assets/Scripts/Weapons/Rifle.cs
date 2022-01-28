using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour, IWeapon
{
	[field: SerializeField] public GameObject ammo { get; set; }

	public void Fire()
	{
		Vector3 pos = transform.Find("Bullet Spawn").position;
		GameObject bullet = Instantiate(ammo, pos, transform.rotation);
		bullet.transform.SetParent(transform.parent.parent);
		MoveToLocalPositionOnOtherBoard(bullet);
	}

	public void MoveToLocalPositionOnOtherBoard(GameObject obj)
	{
		Vector3 localPosition = obj.transform.localPosition;

		if (obj.transform.parent.name.Contains("2"))
		{
			Transform newParent = obj.transform.parent.parent.Find("Player Plane");
			obj.transform.SetParent(newParent);
		}

		else
		{
			Transform newParent = obj.transform.parent.parent.Find("Player Plane 2");
			obj.transform.SetParent(newParent);
		}

		obj.transform.localPosition = localPosition;
	}
}
