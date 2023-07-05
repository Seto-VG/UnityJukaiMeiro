using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject door1; 
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;
    
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject,0.4f);
            Destroy(door1); 
            Destroy(door2);
            Destroy(door3);
            Destroy(door4);
            Destroy(door5);
            Destroy(door6);
            audioSource.PlayOneShot(sound1);

        }
    }
    

    
}