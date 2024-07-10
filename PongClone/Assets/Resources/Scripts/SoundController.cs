using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racquetSound;
    public AudioSource mainMenuSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacquetPlayer1" || collision.gameObject.name == "RacquetPlayer2")
        {
            this.racquetSound.Play();
        }
        else
        {
            this.wallSound.Play();
        }
    }
}
