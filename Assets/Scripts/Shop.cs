using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;

    private PlayerModifiere _playerModifiere;

    private void Start() {
        _playerModifiere = FindAnyObjectByType<PlayerModifiere>();
    }
    
    public void BuyWidth() {
        if(_coinManager.NumberOfCoins >= 20) {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Width += 25;
            _playerModifiere.SetWidth(Progress.Instance.Width);
        }
    }

    public void BuyHeight() {
        if(_coinManager.NumberOfCoins >= 20) {
            _coinManager.SpendMoney(20);
            Progress.Instance.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.Height += 25;
            _playerModifiere.SetHeight(Progress.Instance.Height);
        }
    }
}
