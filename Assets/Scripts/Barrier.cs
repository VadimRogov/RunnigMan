using UnityEngine;

public class Barrier : MonoBehaviour
{

    [SerializeField] GameObject _bricksEffectPrefab;

   private void OnTriggerEnter(Collider other) 
   {
    PlayerModifiere playerModifiere = other.attachedRigidbody.GetComponent<PlayerModifiere>();
    if(playerModifiere) {
        playerModifiere.HitBarrier();
        Destroy(gameObject);
        Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
    }
   }
}
