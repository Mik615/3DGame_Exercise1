using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
	private GameObject WeaponHeld;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Weapon"))
		{
			if (WeaponHeld == null)
			{
				// Attach to holding weapon
				GameObject hand = GameObject.Find("mixamorig:RightHand");
				other.transform.parent = hand.transform;
				other.transform.eulerAngles = hand.transform.rotation.eulerAngles + new Vector3(0, 90, 90);
				other.transform.position = hand.transform.position;
				other.transform.localPosition = new Vector3(0,0.25f,0);
				WeaponHeld = other.gameObject;
			}
			else{
				// Attach to back
				other.transform.Rotate(new Vector3(0, 0, 0));
				other.transform.position = this.transform.GetChild(6).GetComponent<SkinnedMeshRenderer>().bounds.center;
				other.transform.parent = this.transform.GetChild(6);
			}
			
		}
	}
}
