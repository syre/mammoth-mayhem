using UnityEngine;
using System.Collections;

public class MammothBehaviourScript : MonoBehaviour {
	public GameObject[] tribesmen;
	public Transform target;
    public float movementSpeed = 3f;

    private float xDirection = 1f;
    private float yDirection = 1f;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		targetNearestEnemy();
        	moveTowardsEnemy();
	}
	
    void targetNearestEnemy()
	{
	if (tribesmen.Length == 0)
		return;
        var minDistance = Vector2.Distance(transform.position, tribesmen[0].transform.position);
        target = tribesmen[0].transform;

		foreach (GameObject tribesman in tribesmen) 
        {
            var currentDistance = Vector2.Distance(transform.position, tribesman.transform.position);
            if (minDistance > currentDistance)
            {
                minDistance = currentDistance;
                target = tribesman.transform;
            }
		}
			
				
	}
	void moveTowardsEnemy()
	{
	if (target == null)
		return;
        if (Vector2.Distance(transform.position, target.position) < 1)
            return;
        if (transform.position.x > target.position.x)
            xDirection = -1;
        else
            xDirection = 1;
        if (transform.position.y > target.position.y)
            yDirection = -1;
        else
            yDirection = 1;
        
        rigid.velocity = new Vector2(xDirection * movementSpeed, yDirection * movementSpeed);
	}
}
