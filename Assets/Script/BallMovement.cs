using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float ballForce;
    private bool gameStarted = false;

    //Ajoute de la force à la balle
    private void Start()
    {
        rb.AddForce(new Vector2(ballForce, ballForce));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false) 
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce (new Vector2(ballForce, ballForce));
            gameStarted = true;
            
        }
    }
}
