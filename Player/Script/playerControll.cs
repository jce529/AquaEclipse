using UnityEngine;

public class playerControll: MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    public LayerMask groundLayer;


    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    private CapsuleCollider2D capsuleCollider;





    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded())
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
       

        if (rigid.linearVelocity.x > maxSpeed)
            rigid.linearVelocity = new Vector2(maxSpeed, rigid.linearVelocity.y);
        else if (rigid.linearVelocity.x < maxSpeed*(-1))
            rigid.linearVelocity = new Vector2(maxSpeed*(-1), rigid.linearVelocity.y);


    }
 
    bool isGrounded()
    {
        return capsuleCollider.IsTouchingLayers(groundLayer);
    }
}
