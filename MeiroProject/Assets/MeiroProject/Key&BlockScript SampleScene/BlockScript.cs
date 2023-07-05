using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public void DestroyBlock()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Key"))
        {
            DestroyBlock();
        }
    }
}