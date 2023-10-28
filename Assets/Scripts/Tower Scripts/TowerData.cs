using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TowerType
{
    public GameObject visualization;

    public GameObject bullet;
    public float fireRate;
}
public class TowerData : MonoBehaviour
{
    public List<TowerType> types;

    [SerializeField] public TowerType CurrentType;
    /*
     private TowerType _currentType;

    public TowerType CurrentType
    {
        get => _currentType;
        set
        {
            _currentType = value;
            int currentTypeIndex = types.IndexOf(_currentType);

            GameObject typeVisual = types[currentTypeIndex].visualization;
            for (int i = 0; i < types.Count; i++)
            {
                if (typeVisual != null)
                {
                    if (i == currentTypeIndex)
                    {
                        types[i].visualization.SetActive(true);
                    }
                    else
                    {
                        types[i].visualization.SetActive(false);
                    }
                }
            }
        }
    }
    */
}
