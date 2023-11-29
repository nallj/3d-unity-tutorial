using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private string enemyTag = "Enemy Body";
    private bool ded = false;

    [SerializeField] AudioSource deathSound;

    private void Update()
    {
        if (transform.position.y < -1f && !ded)
        {
            Die();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemyTag))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    void Die()
    {
        ded = true;
        deathSound.Play();
        Invoke(nameof(ReloadLife), 1.3f);
    }

    void ReloadLife()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
