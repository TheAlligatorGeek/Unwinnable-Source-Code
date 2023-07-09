using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text Score_UIText;
    public int scoreNumber = 0;
    // Update is called once per frame
    void Update()
    {
        Score_UIText.text = scoreNumber.ToString();
    }
}
