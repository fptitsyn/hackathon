using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Castle : MonoBehaviour{
    [SerializeField] public int hp = 5;
    [SerializeField] TMP_Text textValueHP;

    private void Update(){
        textValueHP.text = hp.ToString();
    }
}
