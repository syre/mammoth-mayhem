using UnityEngine;
using System.Collections;

public class TribesmanBehaviour : MonoBehaviour {
	public float attackTimer = 0f;
	public float attackWaitTime = 1.5f;
	public int destroyAfterSeconds = 5; 
	public GameObject projectile;
	// haha
	public GameObject[] enemies;
	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		targetNearestEnemy();
		Attack();
	}
	void Attack()
	{
		if (target == null)
			return;
		attackTimer += Time.deltaTime;
		if (attackTimer > attackWaitTime) {
			attackTimer = 0f;
			var projectileCopy = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
			var projectileFlight = projectileCopy.GetComponent<ProjectileFlight> ();
			projectileFlight.direction = (target.position - transform.position).normalized;
			Destroy (projectileCopy, destroyAfterSeconds);
		}

	}

	void targetNearestEnemy()
	{
		if (enemies.Length == 0)
			return;
		var minDistance = Vector2.Distance(transform.position, enemies[0].transform.position);
		target = enemies[0].transform;

		foreach (GameObject enemy in enemies) 
		{
			var currentDistance = Vector2.Distance(transform.position, enemy.transform.position);
			if (minDistance > currentDistance)
			{
				minDistance = currentDistance;
				target = enemy.transform;
			}
		}


	}
}
