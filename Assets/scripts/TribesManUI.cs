using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TribesManUI : MonoBehaviour {

	public Text speedText;
	public Text cookText;
	public Text resourceText;
	public Text fightText;

	public GameObject tribesMan;
	public Text name;
	public Text role;
	public Text indexText;
	private int index;
	private bool mapIsShown = false;
	public TribesManHandler handler;
	// Use this for initialization
	void Start () {
		tribesMan.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clickOnTribes(){
		if (mapIsShown) {
			tribesMan.SetActive (false);
			mapIsShown = false;
		} else {
			if (handler.getPlayers ().Count >= index) {
				index = handler.getPlayers ().Count - 1;
			}
			if (handler.getPlayers ().Count > index) {
				if (handler.getPlayers () [index] != null) {
					TribesManStats temp = handler.getPlayers () [index];
					speedText.text = ""+temp.speed;
					cookText.text = ""+temp.cookingAbility;
					resourceText.text = ""+temp.medicinAbility;
					fightText.text = ""+temp.fightingAbility;
					name.text = ""+temp.name;
					role.text = "Role: "+temp.role;
					indexText.text = (index+1) + "/" + handler.getPlayers ().Count;
				}
			}
			tribesMan.SetActive (true);
			mapIsShown = true;
		}
	}

	public void nextPerson(){
		index++;
		if (index >= handler.getPlayers ().Count) {
			index = 0;
		}
		if (index < handler.getPlayers ().Count && index >= 0) {
			TribesManStats temp = handler.getPlayers () [index];
			speedText.text = ""+temp.speed;
			cookText.text = ""+temp.cookingAbility;
			resourceText.text = ""+temp.medicinAbility;
			fightText.text = ""+temp.fightingAbility;
			name.text = ""+temp.name;
			role.text = "Role: "+temp.role;
			indexText.text = (index+1) + "/" + handler.getPlayers ().Count;
		}
	}

	public void backPerson(){
		index--;
		if (index < 0) {
			index = handler.getPlayers ().Count - 1;
		}
		if (index >= 0) {
			TribesManStats temp = handler.getPlayers () [index];
			speedText.text = ""+temp.speed;
			cookText.text = ""+temp.cookingAbility;
			resourceText.text = ""+temp.medicinAbility;
			fightText.text = ""+temp.fightingAbility;
			name.text = ""+temp.name;
			role.text = "Role: "+temp.role;
			indexText.text = (index+1) + "/" + handler.getPlayers ().Count;
		}
	}
}