using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{

    //[SerializeField]private float moveSpeed = 1.0f; 

    //private Transform playerTransform; //player's transform, no longer has serialize field because we checked itself in awake

    private Rigidbody2D rb2D;

    private void Awake()
    {
        //playerTransform = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hey.");
    }

    void PlayerInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //playerTransform.Translate(translation:Vector3.right * moveSpeed * Time.deltaTime);
            rb2D.AddForce(transform.right * 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //playerTransform.Translate(translation: Vector3.left * moveSpeed * Time.deltaTime);
            rb2D.AddForce(transform.right * -1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //playerTransform.Translate(translation: Vector3.down * moveSpeed * Time.deltaTime);
            rb2D.AddForce(transform.up * -1);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //playerTransform.Translate(translation: Vector3.up * moveSpeed * Time.deltaTime);
            rb2D.AddForce(transform.up * 1);
        }

        if (Input.GetKey(KeyCode.Space)) //reload the level if you're stuck
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    public class PlayerData {
        public PlayerData()
        {

        }
    }
}
