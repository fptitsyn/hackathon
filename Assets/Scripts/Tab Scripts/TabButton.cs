using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButton : MonoBehaviour
{
    [SerializeField] public Enemy enemy;
    
    public void ChangeCurrentEnemy()
    {
        TabPanel tab = GetComponentInParent<TabPanel>();
        tab.currentEnemySelected = enemy;
    }
}
