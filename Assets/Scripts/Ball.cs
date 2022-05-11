using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D myBody;
    private Vector2 startPosition;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        startPosition = myBody.transform.position;
        ResetBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeathBorder"))
        {
            FindObjectOfType<GameManager>().LoseLive();
        }
    }

    public void ResetBall()
    {
        myBody.position = startPosition;
        myBody.velocity = Vector2.zero;
        myBody.velocity = new Vector2(Random.Range(-1f, 1f) * speed, 1 * speed);
    }
}
