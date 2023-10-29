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

    void Update(){
        if (castle.hp <= 0)
            SceneManager.LoadScene(1);
        int countNotNullEnemies = 0;
        for (int i = 0; i < enemies.Length; i++)
            countNotNullEnemies += Convert.ToInt32(enemies[i] != null);
        if (countNotNullEnemies == 0 && isPlayGame)
            SceneManager.LoadScene(7);
    }
}
