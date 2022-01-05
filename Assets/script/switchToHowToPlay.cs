using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToHowToPlay : MonoBehaviour {
    public void goToHowToPlay() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void goToStory() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
