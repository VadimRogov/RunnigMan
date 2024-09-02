using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;


    private void OnValidate() {
        _gateAppearaence.UpdateVisual(_deformationType, _value);
    }

    private void OnTriggerEnter(Collider other) 
    {
        PlayerModifiere playerModifiere = other.attachedRigidbody.GetComponent<PlayerModifiere>();
        if(playerModifiere) {
            if(_deformationType == DeformationType.Width) {
                playerModifiere.AddWidth(_value);
            }else if(_deformationType == DeformationType.Height) {
                playerModifiere.AddHeight(_value);
            }
            Destroy(gameObject);
        }
    }
}
