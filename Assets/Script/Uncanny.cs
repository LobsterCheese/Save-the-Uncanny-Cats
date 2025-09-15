using UnityEngine;

public class Uncanny : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Collider2D uncannyCollider;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Flag")
        {
            //Debug.Log("Hitting the thing!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
