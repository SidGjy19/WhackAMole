using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip gameMusic;
    public AudioClip menuMusic;

    void OnEnable()
    {
        GameManager.Instance.onGameStart.AddListener(PlayGameMusic);
        GameManager.Instance.onGameEnd.AddListener(StopMusic);
    }

    void OnDisable()
    {
        GameManager.Instance.onGameStart.RemoveListener(PlayGameMusic);
        GameManager.Instance.onGameEnd.RemoveListener(StopMusic);
    }

    void Start()
    {
        if (menuMusic != null)
        {
            musicSource.clip = menuMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    void PlayGameMusic()
    {
        if (gameMusic != null)
        {
            musicSource.clip = gameMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    void StopMusic()
    {
        musicSource.Stop();
    }
}