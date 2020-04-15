using UnityEngine;

public class CollisionDet : MonoBehaviour
{
    public playerMovement Movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
