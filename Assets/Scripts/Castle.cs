using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour{
    [SerializeField] public int hp = 5;
    [SerializeField] TMP_Text textValueHP;

    private void Update(){
        textValueHP.text = hp.ToString();
        if (hp <= 0)
            SceneManager.LoadScene(3);
    }
}
