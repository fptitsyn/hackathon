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
}
