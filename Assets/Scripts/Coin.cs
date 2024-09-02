using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] GameObject _effectPrefab;

    private void Update() 
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other) {
        Object.FindAnyObjectByType<CoinManager>().AddOne();
        Destroy(gameObject);
        Instantiate(_effectPrefab, transform.position, transform.rotation);
    }
}
