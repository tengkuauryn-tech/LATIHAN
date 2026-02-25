using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float movementSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movementSpeed, -movementSpeed/2f) * Time.deltaTime;
        Debug.Log(transform.position);
    }
}
