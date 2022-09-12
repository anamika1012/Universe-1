using UnityEngine;

public class Universe1_BookScript : MonoBehaviour

{
    public GameObject U1_key1;
    public GameObject U1_key2;
    public GameObject U1_key3;
    public Transform target;
    public float t;
    public AudioSource Correct;

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !U1_key1.activeSelf && !U1_key2.activeSelf && !U1_key3.activeSelf)
        {
            Correct.Play();
            Destroy(gameObject);

            // StartCoroutine(ExecuteAfterTime());
        }
    }

}
