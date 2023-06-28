using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            BlockScript blockScript = collision.gameObject.GetComponent<BlockScript>();
            if (blockScript != null)
            {
                blockScript.DestroyBlock();
            }
        }
    }
}