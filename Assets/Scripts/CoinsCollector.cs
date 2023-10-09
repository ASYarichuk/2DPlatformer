using UnityEngine;

public class CoinsCollector : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<CoinRotator>())
        {
            Destroy(other.gameObject);
        }
    }
}
