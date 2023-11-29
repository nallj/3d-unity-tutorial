using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] TextMeshProUGUI coinsText;
    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            collectionSound.Play();
        }
    }
}
