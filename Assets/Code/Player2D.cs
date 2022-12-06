using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Player2D : MonoBehaviour
{
    [SerializeField] ushort speed = 200;
    float InputX;
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        InputX = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(InputX * speed * Time.fixedDeltaTime, body.velocity.y);
    }
}