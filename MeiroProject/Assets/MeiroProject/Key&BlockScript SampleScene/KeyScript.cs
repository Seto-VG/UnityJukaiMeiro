using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject door_1; 
    public GameObject door_2_Right;
    public GameObject door_2_Left;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(door_1);
            Destroy(door_2_Right);
            Destroy(door_2_Left);

        }
    }
    

    
}