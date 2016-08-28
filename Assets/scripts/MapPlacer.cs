using UnityEngine;
using System.Collections;

public class MapPlacer : MonoBehaviour {

	public GameObject tilesPrefab;
	public GameObject mapWithoutContentsPrefab;
	public GameObject fullcontentMapPrefab;
	public GameObject[][] tiles;
	public GameObject tentPrefab;
	private GameObject tent;
	private GameObject mapWithoutContents;
	private GameObject mapWithContents;
	public float startXLocation;
	public float startYLocation;
	private bool isHidden = true;
	// Use this for initialization
	void Start () {
		generateMap ();
		hideMap ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void generateMap(){
		mapWithContents = Instantiate (fullcontentMapPrefab) as GameObject;
		mapWithoutContents = Instantiate (mapWithoutContentsPrefab) as GameObject;
		tent = Instantiate (tentPrefab) as GameObject;
		float xSize = tilesPrefab.GetComponent<SpriteRenderer> ().bounds.size.x;
		float ySize = tilesPrefab.GetComponent<SpriteRenderer> ().bounds.size.y;
		tiles = new GameObject[40][];
		for(int i = 0; i < 40; i++) {
			tiles [i] = new GameObject[40];
		}
		for (int i = 0; i < 40; i++) {
			for (int x = 0; x < 40; x++) {
				GameObject temp = Instantiate (tilesPrefab) as GameObject;
				temp.transform.position = new Vector3 (startXLocation + i * xSize, startYLocation - x * ySize, 1f);
				tiles [i] [x] = temp;
			}
		}
	}

	public void clickOnMap(){
		if (isHidden) {
			showMap ();
		} else {
			hideMap ();
		}
	}

	public void hideMap(){
		mapWithContents.gameObject.SetActive (false);
		mapWithoutContents.gameObject.SetActive (false);
		tent.gameObject.SetActive (false);
		for (int i = 0; i < 40; i++) {
			for (int x = 0; x < 40; x++) {
				if (tiles [i] [x] != null) {
					tiles [i] [x].gameObject.SetActive (false);
				}
			}
		}
		isHidden = true;
	}

	public void showMap(){
		mapWithContents.gameObject.SetActive (true);
		mapWithoutContents.gameObject.SetActive (true);
		tent.gameObject.SetActive (true);
		for (int i = 0; i < 40; i++) {
			for (int x = 0; x < 40; x++) {
				if (tiles [i] [x] != null) {
					tiles [i] [x].gameObject.SetActive (true);
				}

			}
		}
		isHidden = false;
	}

	public void justATest(){
		bool comp = true;
		while (comp) {
			int random = Random.Range (0, 40);
			int random2 = Random.Range (0, 40);
			if (tiles [random] [random2] != null) {
				Destroy (tiles [random] [random2]);
				comp = false;
			}
		}
	}
}
