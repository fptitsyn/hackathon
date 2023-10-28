using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public AudioSource mainButton;

    public void playMainButton()
    {
        mainButton.Play();
    }
}
