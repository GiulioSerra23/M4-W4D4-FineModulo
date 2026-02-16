using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEditor.Rendering;
using UnityEngine;

public class AltitudeBullet : Bullet
{
    //[Header ("References")]
    //[SerializeField] private SlowTrap _trapPrefab;

    [Header("Bullet Settings")]
    //[SerializeField] private bool _useAltitude;
    [SerializeField] private float _altitude = 10f;

    public override void SetUp(Vector3 direction, float speed)
    {
        if (_rb == null) _rb = GetComponent<Rigidbody>();

        //if (_useAltitude)
        //{
        //    _rb.velocity = direction * speed + Vector3.up * _altitude;
        //}
        //else
        //{
        //    _rb.velocity = direction * speed;
        //}

        _rb.velocity = direction * speed + Vector3.up * _altitude;
    }

    //private void SpawnTrapFromHit()
    //{
    //    SlowTrap trapClone = Instantiate(_trapPrefab, transform.position, Quaternion.identity);        
    //}

    //protected override void OnCollisionEnter(Collision collision)
    //{
    //    base.OnCollisionEnter(collision);

    //    if (collision.collider.CompareTag(Tags.Ground))
    //    {
    //        SpawnTrapFromHit();
    //    }
    //}
}
