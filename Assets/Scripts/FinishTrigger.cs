using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
     private void OnTriggerEnter(Collider other) {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if(playerBehaviour) {
            playerBehaviour.StartFinishBehaviour();
            FindAnyObjectByType<GameManager>().ShowFinishWindow();
        }
    }
}
