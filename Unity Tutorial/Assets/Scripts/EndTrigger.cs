using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameM;

    void OnTriggerEnter()
    {
        gameM.CompleteLevel();
    }
}
