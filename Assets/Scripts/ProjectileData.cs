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
    protected float _projectileSpeed;

    [SerializeField]
    protected float _projectileLifeTime;
}
