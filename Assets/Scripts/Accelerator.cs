using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : ProjectileData
{

    private void Start()
    {
        Destroy(gameObject, _projectileLifeTime);
    }
    void FixedUpdate()
    {
        transform.Translate(_projectileSpeed * Time.deltaTime * Vector3.forward);
    }
}
