using UnityEngine;
using System.Collections;

public class ProjectileFlight : MonoBehaviour {
    public int damage = 2;
    public float velocity = 1;
    public Vector2 direction = new Vector2 (1f, 1f);
    private Rigidbody2D projectileBody;

	// Use this for initialization
	void Start () {
		projectileBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		projectileBody.velocity = direction * velocity;
	}

	void OnTriggerEnter2D(Collider2D info)
	{
		if (info.gameObject.tag == "Monster") 
		{
			info.gameObject.GetComponent<MonsterHealth> ().takeDamage (damage);
			Destroy (gameObject);
		} else 
		{
			Destroy (gameObject);	
		}
	}
}
