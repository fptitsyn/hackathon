using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public AudioSource mainButton;
    public AudioSource secondaryButton; 

    public void playMainButton()
    {
        mainButton.Play();
    }

    public void playSecondaryButton()
    {
        secondaryButton.Play();
    }
}
