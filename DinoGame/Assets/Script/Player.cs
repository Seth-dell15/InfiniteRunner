using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // "wasPressedThisFrame" sur n'importe quel appareil
        // Keyboard.current.anyKey détecte n'importe quelle touche du clavier
        // Pointer.current.press détecte le clic gauche ou le toucher tactile

        bool inputDetecte = false;

        if (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame)
            inputDetecte = true;

        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
            inputDetecte = true;

        if (inputDetecte && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
            anim.SetBool("isJumping", true);

            // Optionnel : On retire le parent pour que le saut soit fluide
            transform.SetParent(null);
        }
    }

    // Détection simplifiée du sol
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("isJumping", false);
        }
    }
}