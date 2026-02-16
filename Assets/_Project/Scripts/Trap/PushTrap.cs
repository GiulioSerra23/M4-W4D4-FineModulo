using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTrap : MonoBehaviour
{
    [Header ("Trap Settings")]
    [SerializeField] private int _damage;
    [SerializeField] private float _lifeSpan = 10f;

    private void Start()
    {
        Destroy(gameObject, _lifeSpan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag(Tags.Player)) return;

        if (!collision.collider.TryGetComponent<LifeController>(out var lifeController)) return;

        lifeController.TakeDamage(_damage);
    }
}
