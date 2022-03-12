using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    public float Speed = 15.0f;
    private float xRange = 15.0f, zMin = -1.5f, zMax = 15.5f;

    public GameObject projectilePrefab;

    void Update()
    {
        if (GamingManager.GameContinue)
        {
            Movement();
        }        
    }
    public void Movement()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * Speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
