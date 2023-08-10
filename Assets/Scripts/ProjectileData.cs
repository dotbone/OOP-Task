using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileData : MonoBehaviour
{
    [SerializeField]
    private Enums.ProjectileType _projectileType;

    [SerializeField]
    private int _projectileDamage;

    [SerializeField]
    private float _projectileSpeed;

    [SerializeField]
    private float _projectileLifeTime;
}
