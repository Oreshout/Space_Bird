using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Logic_Script logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();

        logic.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody = GetComponent<Rigidbody2D>();
            myRigidbody.rotation = -45;         
            myRigidbody.linearVelocity = Vector2.up * flapstrength;

            Debug.Log("Bonjour");
        }
        else if (birdIsAlive)
        {
            myRigidbody.rotation = -90;
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            logic.quitGame();
        }

        Bordure();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

   private void Bordure()
    {
        if(myRigidbody.position.y < -10)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        else if(myRigidbody.position.y > 10)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
