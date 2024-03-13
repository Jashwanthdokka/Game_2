using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public Text livesText;

    // Update is called once per frame
    void Update()
    {
        // Update the text to show the remaining lives from the GameData class
        livesText.text = "Lives: " + GameData.lives.ToString();
    }
}
