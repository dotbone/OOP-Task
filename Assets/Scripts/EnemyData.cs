using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    [SerializeField]
    private Enums.EnemyType enemyType;

    [SerializeField]
    private Enums.ProjectileType ProjectileType;

    [SerializeField]
    private int _health;

    [SerializeField]
    private float _attackSpeed;

    [SerializeField]
    private float _attacRange;

    [SerializeField]
    private float _movementSpeed;
}
