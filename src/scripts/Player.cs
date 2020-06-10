using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 10f;

	public Camera camera;
	Rigidbody2D rb;

	float movement = 0f;
	private float criticalDistance = 15f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;

		if (transform.position.x > camera.orthographicSize || transform.position.x < -camera.orthographicSize) {
			Vector2 newPos = transform.position;
			newPos.x = -newPos.x;
			transform.position = newPos;
		}

		if ((camera.transform.position - transform.position).y > criticalDistance) {
            Destroy(gameObject);
        }
	}
}
