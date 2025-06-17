using UnityEngine;

public class Player_movement1 : MonoBehaviour
{
    public float jumpForce = 7f;
    public Transform groundCheck;
    public float checkRadius = 0.1f;
    public LayerMask groundLayer;

    [SerializeField] private SpriteRenderer spriterenderer;

    private float playerHalfHeight;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        playerHalfHeight = spriterenderer.bounds.extents.y;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool hit = Physics2D.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("ground"));

        if (Input.GetKeyDown(KeyCode.Space) && hit)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }


    }
}
