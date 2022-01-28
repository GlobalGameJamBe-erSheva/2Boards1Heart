using System.Collections;
using UnityEngine;

public class Rifle : MonoBehaviour, IWeapon
{
	[field: SerializeField] public GameObject ammo { get; set; }
	[field: SerializeField] public int fireRate;

	bool allowFire = true;

	public void Fire()
    {
		StartCoroutine(Shoot());
    }

	public IEnumerator Shoot()
	{
		if (!allowFire) {
			yield return new WaitForSeconds(0);
		}else {
			allowFire = false;

			Vector3 pos = transform.Find("Bullet Spawn").position;
			GameObject bullet = Instantiate(ammo, pos, transform.rotation);
			bullet.transform.SetParent(transform.parent.parent);
			MoveToLocalPositionOnOtherBoard(bullet);

			yield return new WaitForSeconds(fireRate);
			allowFire = true;
	    }
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
