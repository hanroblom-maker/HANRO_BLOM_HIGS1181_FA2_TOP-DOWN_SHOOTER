using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintMultiplier = 1.5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    public GameObject bulletPrefab;

    public Transform firePoint;

    public float bulletSpeed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
        Sprint();
        isShooting();
    }

    void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void Sprint()
    {
        float currentSpeed = moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= sprintMultiplier;
        }

        rb.linearVelocity = moveInput * currentSpeed;
    }

    void isShooting()

    {

        if (Input.GetKeyDown(KeyCode.Space))

        {

            Shoot();

        }

    }



    void Shoot()

    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);



        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        bulletRb.linearVelocity = transform.up * bulletSpeed;



        Debug.Log("Bullet Fired");

    }
}
