using UnityEngine;

public class dontDie : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        AudioSource m_catSong = GetComponent<AudioSource>();
        m_catSong.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
