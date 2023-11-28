using UnityEngine;

public class StickierPlatform : MonoBehaviour
{
    string playerGameObjectName = "Player";

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == playerGameObjectName)
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == playerGameObjectName)
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
