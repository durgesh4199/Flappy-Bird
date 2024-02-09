using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0;
    [SerializeField] float playerJump = 0;

    private Rigidbody2D playerRB;
    private SManager SceneMCode;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();  // calling the Player gameobject Rigidbody component
        SceneMCode = GameObject.Find("SceneManager").GetComponent<SManager>();   // Calling the SceneManager Script
    }
    private void FixedUpdate()
    {
        transform.Translate(1 * playerSpeed * Time.deltaTime, 0, 0);   // player move Forward
    }
    void Update()
    {
        PlayerJumped();              // Player jump with Space
        DestroyOnOutOfBoundary();    // Player die Whhen out of Boundary
    }
    private void DestroyOnOutOfBoundary()
    {
        if(transform.position.y <= -6 || transform.position.y >= 6)
        {
            SceneMCode.PlayerIsDead();
            Destroy(this.gameObject);
            
        }
    }
    private void PlayerJumped()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.velocity = Vector2.up * playerJump;
        }
    }

}
