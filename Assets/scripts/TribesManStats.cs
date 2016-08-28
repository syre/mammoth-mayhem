using UnityEngine;
using System.Collections;

public class TribesManStats {

	public string name;
	public int role;
	/*
	 * 0 = undefined
	 * 1 = medicin man
	 * 2 = cook
	 * 3 = scout
	 * 4 = fighter
	 */
	public int maxHealthPoints = 10;
	public int currentHealthPoints = 10;
	public int speed = 1;
	public int cookingAbility = 1;
	public int fightingAbility = 1;
	public int medicinAbility = 1;
	public int scoutAbility = 1;

	public TribesManStats(string name, int role){
		this.name = name;
		this.role = role;
		if (role > 3 || role < 0) {
			role = 0;
		}
	}

	void takeDmg(int damage)
	{
		if (damage >= currentHealthPoints)
		{
			// Death
		}
		else
		{
			currentHealthPoints -= damage;
		}
	}

	public void giveMonthlyStats(){
		if (role == 1) {
			medicinAbility++;
		} else if (role == 2){
			cookingAbility++;
		} else if (role == 3){
			scoutAbility++;
		} else if (role == 4){
			fightingAbility++;
		}
	}

	public string returnRoleName(){
		if (role == 1) {
			return "Medicin Man";
		} else if (role == 2) {
			return "Cook";
		} else if (role == 3) {
			return "Scout";
		} else if (role == 4) {
			return "Fighter";
		} else {
			return "Undefined";
		}
	}
}
