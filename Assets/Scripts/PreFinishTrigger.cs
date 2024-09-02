using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if(playerBehaviour) {
            playerBehaviour.StartPreFinishBehaviour();
        }
    }
}
