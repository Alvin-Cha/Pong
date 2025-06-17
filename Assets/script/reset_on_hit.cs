using UnityEngine;

public class reset_on_hit : MonoBehaviour
{
    public float startingSpeed = 5f;

    private void OnTriggerEnter2D(Collider2D other)
{
    if (!other.CompareTag("Ball")) return; // Ignore everything except the ball

    // Call correct life loss
    if (gameObject.name == "Hitbox1")
        FindObjectOfType<game_manager>().LoseLifePlayer1();
    else if (gameObject.name == "Hitbox2")
        FindObjectOfType<game_manager>().LoseLifePlayer2();

    // Reset ball
    other.transform.position = Vector2.zero;

    Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
    rb.velocity = Vector2.zero;

    float x = Random.value > 0.5f ? 1f : -1f;
    float y = Random.Range(-0.5f, 0.5f);
    rb.velocity = new Vector2(x, y).normalized * startingSpeed;
}

}
