using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    int catsToCanny;
    public TextMeshProUGUI mText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        catsToCanny = GameObject.FindGameObjectsWithTag("Uncanny").Length;
        //Debug.Log(catsToCanny);
    }

    // Update is called once per frame
    void Update()
    {
        catsToCanny = GameObject.FindGameObjectsWithTag("Uncanny").Length;
        //Debug.Log(catsToCanny);
        if (catsToCanny <= 0)
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
            else if (SceneManager.GetActiveScene().name == "Level3")
            {
                SceneManager.LoadScene("Level4");
            }
            else if (SceneManager.GetActiveScene().name == "Level4")
            {
                SceneManager.LoadScene("Level5");
            }
            else if (SceneManager.GetActiveScene().name == "Level5")
            {
                SceneManager.LoadScene("Level6");
            }
            else if (SceneManager.GetActiveScene().name == "Level6")
            {
                SceneManager.LoadScene("Level7");
            }
            else if (SceneManager.GetActiveScene().name == "Level7")
            {
                SceneManager.LoadScene("Level8");
            }
            else if (SceneManager.GetActiveScene().name == "Level8")
            {
                SceneManager.LoadScene("Level9");
            }
            else if (SceneManager.GetActiveScene().name == "Level9")
            {
                SceneManager.LoadScene("Level10");
            }

            if (SceneManager.GetActiveScene().name == "Level10")
            {
                mText.text = "You win";
            }
        }
    }
}
