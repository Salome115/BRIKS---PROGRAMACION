using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.velocity = new Vector2(Random.Range(-1f, 1f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
