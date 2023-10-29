using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButton : MonoBehaviour
{
    [SerializeField] public Enemy enemy;
    private TabPanel _tab;

    private void Start()
    {
        _tab = GetComponentInParent<TabPanel>();
    }

    public void ChangeCurrentEnemy()
    {
        _tab.currentEnemySelected = enemy;
    }
}
