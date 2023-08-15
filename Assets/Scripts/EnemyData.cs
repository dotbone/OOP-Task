using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    [SerializeField]
    private Enums.EnemyType enemyType;

    [SerializeField]
    public Enums.ProjectileType ProjectileType;

    [SerializeField]
    private int _health;

    [field: SerializeField]
    public float AttackSpeed { get; private set; }

    [SerializeField]
    public float _attackRange;                       

    [SerializeField]
    private float _movementSpeed;
}
