using UnityEngine;

public class Progress : MonoBehaviour
{
    public int Coins;
    public int Height;
    public int Width;

    public static Progress Instance;

    private void Awake() // Специальный метод который вызывается перед методом Start()
    {
        if(Instance == null) {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);  // С этим методом объект не будет уничножаться при переходе между сценами
            Instance = this;
        }else {
            Destroy(gameObject);
        }
    }
}
