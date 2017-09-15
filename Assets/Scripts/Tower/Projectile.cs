using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum proType {
	rock, arrow, fireball
};

public class Projectile : MonoBehaviour {

	[SerializeField]
	private int attackStrenght;

	[SerializeField]
	private proType projectileType;

	public int AttackStrength {
		get {
			return attackStrenght;	
		}
	}

	public proType ProjectileType {
		get {
			return projectileType;
		}
	}
}