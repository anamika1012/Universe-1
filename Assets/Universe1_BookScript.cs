using UnityEngine;

public class Universe1_BookScript : MonoBehaviour

{
    public GameObject U1_key1;
    public GameObject U1_key2;
    public GameObject U1_key3;
    public Transform target;
    public moveBook bookmove;
    public float t;
    public AudioSource findpage;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") &&(U1_key1.activeSelf || U1_key2.activeSelf ||U1_key3.activeSelf))
        {
            findpage.Play();
        }
            
        else if (other.CompareTag("Player") && !U1_key1.activeSelf && !U1_key2.activeSelf && !U1_key3.activeSelf)
        {
            //Correct.Play();
            Destroy(gameObject);
            Destroy(gameObject);
            Destroy(gameObject);
            bookmove.sceptor();

            // StartCoroutine(ExecuteAfterTime());
        }
    }

}
