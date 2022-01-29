using System.Collections;
using UnityEngine;

public class Rifle : MonoBehaviour, IWeapon
{
	[field: SerializeField] public GameObject ammo { get; set; }
    [field: SerializeField] public float fireRate;

	protected bool allowFire = true;

	public virtual void Fire()
    {
		StartCoroutine(Shoot());
    }

	IEnumerator Shoot()
	{
		if (!allowFire) 
		{
			yield return null;
		}
		
		else 
		{
			allowFire = false;

			Vector3 pos = transform.Find("Bullet Spawn").position;
			GameObject bullet = Instantiate(ammo, pos, transform.rotation);
			Destroy(bullet, 3);
			bullet.transform.SetParent(transform.parent.parent);
			MoveToLocalPositionOnOtherBoard(bullet);
			yield return new WaitForSeconds(fireRate);
			allowFire = true;
	    }
	}

	public void MoveToLocalPositionOnOtherBoard(GameObject obj)
	{
		Vector3 localPosition = obj.transform.localPosition;
		ManagerInfo info = SceneManager.GetInfo();
		if (obj.transform.parent.name.Contains("2"))
		{
			Transform newParent = info.Plane1.transform;
			obj.transform.SetParent(newParent);

		}

		else
		{
			Transform newParent = info.Plane2.transform;
			obj.transform.SetParent(newParent);
		}
		obj.GetComponent<Projectile>().SetTrigger(obj.transform.parent.GetComponent<BoxCollider>());
		obj.transform.localPosition = localPosition;
	}
}
