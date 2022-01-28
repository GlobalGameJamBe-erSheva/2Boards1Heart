using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	[SerializeField] PlayerNumber number;

	public Vector3 GetDirectionVector()
	{
		Vector3 direction = Vector3.zero;
		if (number.Equals(PlayerNumber.ONE))
		{
			float horizontal = Input.GetAxis("Horizontal-Player1");
			float vertical = Input.GetAxis("Vertical-Player1");
			direction = new Vector3(horizontal, 0, vertical);
		}

		else if (number.Equals(PlayerNumber.TWO))
		{
			float horizontal = Input.GetAxis("Horizontal-Player2");
			float vertical = Input.GetAxis("Vertical-Player2");
			direction = new Vector3(horizontal, 0, vertical);
		}

		return direction;
	}

	public bool IsAttacking()
	{
		bool res = false;

		if (number.Equals(PlayerNumber.ONE))
		{
			res = Input.GetButtonDown("Fire1");
		}

		else if (number.Equals(PlayerNumber.TWO))
		{
			res = Input.GetButtonDown("Fire2");
		}

		return res;
	}
}
