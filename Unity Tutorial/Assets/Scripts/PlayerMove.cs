using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardF = 2000f;
    public float jumpF = 20000f;
    public float sideF = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardF * Time.deltaTime);

        if (rb.position.y <= 1.5f)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(0, jumpF * Time.deltaTime, 0);
            }
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
