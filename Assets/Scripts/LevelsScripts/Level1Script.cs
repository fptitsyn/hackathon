using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Script : MonoBehaviour{
    [SerializeField] public Castle castle;
    public Enemy[] enemies;
    public bool isPlayGame = false;

    public void StartGame() => isPlayGame = true;

    public void EndGame() => isPlayGame = false;

    private void LateUpdate(){
        if (castle.hp <= 0)
            SceneManager.LoadScene(1);
        int counNotNullEnemies = 0;
        for (int i = 0; i < enemies.Length; i++)
            counNotNullEnemies += Convert.ToInt32(enemies[i] != null);
        Debug.Log(counNotNullEnemies);
        if (counNotNullEnemies == 0 && isPlayGame)
            SceneManager.LoadScene(7);
    }
}
