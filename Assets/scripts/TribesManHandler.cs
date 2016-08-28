using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TribesManHandler : MonoBehaviour {

	private List<TribesManStats> players;
	private string[] names = new string[]{"Soren", "Nicolaj", 
		"Otto", "Julian", "Ṕat", "Reid", "Numbers", "Freddie", "Bobby", 
		"Paris", "Winfred", "Roman", "Quintin", "Chance", "Sherwood", "Lemuel", 
		"Douglass", "Adrian", "Kristofer", "Micheal", "Hugo", "Graham", "Ariel", 
		"Ali", "Carlos", "Alphonse", "Humberto", "Timothy", "Roy", "John", 
		"Julius", "Edison", "Adolfo", "Marcelo", "Tommie", "Sidney", "Jamar", 
		"Sal", "Marc", "Rodney", "Morgan", "Desmond", "Glenn", "Dan"};
	// Use this for initialization
	void Start () {
		players = new List<TribesManStats> ();
		createMen ();
	}

	private void createMen(){
		for (int i = 0; i < 20; i++) {
			string name = names [Random.Range (0, names.Length)];
			players.Add (new TribesManStats (name,0));
		}
	}

	public List<TribesManStats> getPlayers(){
		return players;
	}

	public void giveMonthlyStats(){
		for (int i = 0; i < 20; i++) {
			players [i].giveMonthlyStats ();
		}
	}
}