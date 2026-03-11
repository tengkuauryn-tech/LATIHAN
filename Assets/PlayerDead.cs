using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Player Dead");
            Destroy(gameObject);
        }
    }
}