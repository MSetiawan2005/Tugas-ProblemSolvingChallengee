using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy1 : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            scoreManager.IncrementCurrentScore(1);
            Destroy(collision.gameObject);
        }
    }
}
