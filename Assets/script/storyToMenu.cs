using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storyToMenu : MonoBehaviour{
    public void back() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
