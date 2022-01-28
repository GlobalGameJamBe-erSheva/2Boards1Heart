using UnityEngine;

public interface IWeapon
{
	public void Fire();
	public GameObject ammo { get; set; }
	public void MoveToLocalPositionOnOtherBoard(GameObject obj);
}