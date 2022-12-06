using UnityEngine;
public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 460, timeDisable = 3;
    float t;
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        t += Time.deltaTime;
        if (t > timeDisable) Disable();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Disable();
    }
    void Disable()
    {
        t = 0;
        gameObject.SetActive(false);
    }
    void FixedUpdate()
    {
        body.velocity = transform.TransformDirection(new Vector2(0, speed * Time.fixedDeltaTime));
    }
}