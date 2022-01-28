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

			Vector3 pos;
			pos = transform.Find("Bullet Spawn").position;
			Instantiate<GameObject>(ammo, pos, transform.rotation);
			yield return new WaitForSeconds(fireRate);
			allowFire = true;
	    }
	}

	public Vector3 LocateSpawnPositionOnOtherBoard()
	{
		throw new System.NotImplementedException();
	}
}
