using UnityEngine;

public class Funny_Ninja_Script : MonoBehaviour
{
    public Rigidbody2D Genji;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if(Input.GetKey(KeyCode.Alpha1))
        {
            transform.position += (Vector3.left * speed) * Time.deltaTime;
            transform.position += (Vector3.down * speed) * Time.deltaTime;
            Debug.Log("Genji is moving");
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.up * speed) * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.position += (Vector3.down * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * speed) * Time.deltaTime;
        }

    }
}
