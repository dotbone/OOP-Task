using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    [SerializeField]
    GameObject arrowPrefab;

    [SerializeField]
    Transform shootingPoint;

    [SerializeField]
    float _shootingDelay;

    bool _canShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_canShoot != true && Input.GetMouseButton(0))
        {
            StartCoroutine(ShootingDelay());
            Instantiate(arrowPrefab, shootingPoint.position, Quaternion.identity);
        }
    }

    IEnumerator ShootingDelay()
    {
        _canShoot = true;
        yield return new WaitForSeconds(_shootingDelay);
        _canShoot = false;
    }
}
