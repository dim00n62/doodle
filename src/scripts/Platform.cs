using UnityEngine;

public class Platform : MonoBehaviour
{

    public float jumpForce = 10f;
    public Transform camera;

    private float destroyDistance = 10f;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
        }
    }

    void Update() {
        if ((camera.position - transform.position).y > destroyDistance) {
            Destroy(gameObject);
        }
    }
}
