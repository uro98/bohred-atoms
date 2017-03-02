using UnityEngine;
using System.Collections;

public class WinMusicPlayer : MonoBehaviour
{

    public AudioClip Hallelujah;
    public AudioClip Yay;
    public AudioClip Cheer;

    private int number;

    AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void PlayWinMusic()
    {
        number = Random.Range(0, 3);

        switch (number)
        {
            case 0:
                music.PlayOneShot(Hallelujah, 2f);
                break;
            case 1:
                music.PlayOneShot(Yay, 0.5f);
                break;
            case 2:
                music.PlayOneShot(Cheer, 0.7f);
                break;
        }
    }
}