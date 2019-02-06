using UnityEngine;

public class PlayerColli : MonoBehaviour
{

    public PlayerMove move;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
