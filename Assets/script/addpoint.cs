using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class addpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    public int point;
    void Start()
    {
    }
    public void add()
    {
        point = int.Parse(score.text) + 1;
        score.text = point.ToString();
    }
    // Update is called once per frame
    void Update()
    {
       
    }


}
