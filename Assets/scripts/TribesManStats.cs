using UnityEngine;
using System.Collections;

public class TribesManStats : MonoBehaviour {

	public int healthPoints = 10;
	public int speed = 1;
	public int cookingAbility = 1;
	public int fightingAbility = 1;

	void takeDmg(int damage)
	{
		if (damage > healthPoints)
		{
			// Death
		}
		else
		{
			damage -= healthPoints;
		}
	}
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
