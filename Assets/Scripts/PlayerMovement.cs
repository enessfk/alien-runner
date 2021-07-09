using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardMovement;
    public float sidewaysMovement;

    void Start()
    {
    }

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardMovement*Time.deltaTime);

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameMenager>().EndGame();
        }
        

        
    }
}
