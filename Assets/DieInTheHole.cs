using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieInTheHole : MonoBehaviour
{
    private AudioSource screamSoundSource;

    private bool goToEndGame = false;
    // Start is called before the first frame update
    void Start()
    {
        screamSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[2];

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0) {
            if (!screamSoundSource.isPlaying) {
                if (goToEndGame == true) {
                    SceneManager.LoadScene("GameOver");
                } else {
                    screamSoundSource.Play();
                    goToEndGame = true;
                }
            }
        }
    }
}
