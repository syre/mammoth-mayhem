using UnityEngine;
using System.Collections;

public class MonsterHealth : MonoBehaviour {
    public float health = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    	{
        if (health <= 0)
        {
            Destroy(gameObject);
        }
	
	}

    public void takeDamage(int damage)
    {
        if (health - damage >= 0)
        {
            health -= damage;
        }
    }
}
