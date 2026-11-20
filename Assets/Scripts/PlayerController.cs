using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static bool isRunningNow = false;
    public float jumpForce = 13f;
    Rigidbody2D rb;
    Animator anim;
    bool yerde = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        isRunningNow = Input.GetKey(KeyCode.D);
        anim.SetBool("isRunning", isRunningNow);

        if (Input.GetKeyDown(KeyCode.Space) && yerde)
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
            yerde = false;
            anim.SetTrigger("Jump");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // 1) Normal zemin
        if (col.gameObject.CompareTag("Ground"))
        {
            yerde = true;
            return;
        }

        // 2) Tramvay - üstten gelirse yaşa, yandan gelirse öl
        if (col.gameObject.CompareTag("Tram"))
        {
            float tramTop = col.collider.bounds.max.y;
            bool usttenGeliyor = transform.position.y > tramTop - 0.3f && rb.linearVelocity.y <= 0.1f;

            if (usttenGeliyor)
            {
                yerde = true;
            }
            else
            {
                Ol();
            }
            return;
        }

        // 3) Engel
        if (col.gameObject.CompareTag("Obstacle"))
        {
            Ol();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Kestane"))
        {
            ScoreManager.instance.KestaneAl();
            Destroy(col.gameObject);
        }
    }

    // ölme işlemini tek yerde topladık
    void Ol()
    {
        if (ScoreManager.instance != null)
            ScoreManager.instance.Sifirla();

        if (GameManager.Instance != null)
            GameManager.Instance.GameOver();
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}