using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBullet : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;

    [Range(0f, 1f)]
    public float bounciness;
    public bool useGravity;

    public int explosionDamage;
    public float explosionRange;

    public int maxCollisions;
    public float maxLifeTime;
    public bool explodeOnTouch = true;

    int collisions;
    PhysicMaterial physics_mat;

    private void Start()
    {
        Setup();
    }
    // dsds dsds
    private void Update()
    {
        if (collisions > maxCollisions) Explode();

        maxLifeTime -= Time.deltaTime;
        if (maxLifeTime <= 0) Explode();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void Explode()
    {

    }

    private void Setup()
    {
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;

        GetComponent<SphereCollider>().material = physics_mat;

        rb.useGravity = useGravity;
    }
}
