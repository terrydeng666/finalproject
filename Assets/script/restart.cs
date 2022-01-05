using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData e) {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(1);
    }
}
