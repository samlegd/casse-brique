using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private float speed = 0f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Appel des méthodes pour permettre au joueur de bouger
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position = new Vector2(transform.position.x + x * speed, transform.position.y);
    }
}
