using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float  forwardForce = 500f;
    public float sideForce = 500f;
    private int score = 0;
    public int health = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime,0,0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime,0,0);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
         // Check if the entered collider has the "Pickup" tag.
        if (other.CompareTag("Pickup"))
        {
            // Increment the score.
            score++;

            // Print the new score to the console.
            Debug.Log("Score: " + score);

            // Disable or destroy the Coin object.
            // You can choose either option depending on your game logic.
            // For disabling:
            other.gameObject.SetActive(false);

            // For destroying:
            // Destroy(other.gameObject);
        }

        if (other.CompareTag("Trap" ))
        {
            health--;

            Debug.Log("Health: " + health);

        }
    }
}
