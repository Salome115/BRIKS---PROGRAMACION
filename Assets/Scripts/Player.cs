using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D myBody;
    [SerializeField] float moveSpeed;
    private float inputValue;
    private Vector2 startPosition;

    private void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        startPosition = myBody.transform.position;
    }

    void FixedUpdate()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue > 0)
        {
            myBody.velocity = new Vector2(inputValue * moveSpeed, 0);
        }
        if(inputValue < 0)
        {
            myBody.velocity = new Vector2(inputValue * moveSpeed, 0);
        }
        if(inputValue == 0)
        {
            myBody.velocity = Vector2.zero;
        }
    }

    public void ResetPlayer()
    {
        myBody.position = startPosition;
        myBody.velocity = Vector2.zero;
    }
}
