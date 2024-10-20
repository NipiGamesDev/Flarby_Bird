using UnityEngine;

public class BirdScript : MonoBehaviour
{
    
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public logicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrength;
        }
        if (Input.touchCount > 0)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
