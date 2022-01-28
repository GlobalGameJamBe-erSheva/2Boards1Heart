using UnityEngine;

public interface IWeapon
{
	public void Fire();
	public GameObject ammo { get; set; }
	public Vector3 LocateSpawnPositionOnOtherBoard();
}