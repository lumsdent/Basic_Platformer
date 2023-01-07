using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    Vector2 movement;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = new Vector3(+movement.x, movement.y, 0f) * speed;
    }

    public void OnMove(InputValue move)
    {
        movement = move.Get<Vector2>();

    }
    
}
