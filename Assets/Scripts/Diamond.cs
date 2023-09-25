using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTrigggerExit(Collider other)

    {
        if (other.tag == "Player")
        {
            FindObjectOfType<ScoreManager>().UpdateScore();
            Destroy(gameObject);
            print("hello");
 
        }
    }
}
