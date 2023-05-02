using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      float moveInput = Input.GetAxisRaw("Horizontal");
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject platform2 = GameObject.FindGameObjectWithTag("Platform2");
        BoxCollider2D platform2Collider = platform2.GetComponent<BoxCollider2D>();
        GameObject platform = GameObject.FindGameObjectWithTag("Platform");
        BoxCollider2D platformCollider = platform.GetComponent<BoxCollider2D>();
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Collision");
            Destroy(other.gameObject);

            // Trouver l'objet avec le tag "Platform"
            platformCollider.enabled = true;
            platform2Collider.enabled = false;
        }

        if (other.gameObject.CompareTag("Coin2"))
        {
            Debug.Log("Collision");
            Destroy(other.gameObject);

            // Trouver l'objet avec le tag "Platform"
            platform2Collider.enabled = true;
            platformCollider.enabled = false;
        }
    }
}
