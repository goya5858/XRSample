using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class CustomGunShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileSpawnPoint;
    public float projectileSpeed = 1000f;
    public float projectileLife = 5f;

    XRGrabInteractable m_InteractableBase;  //from XR toolkit

    void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.onSelectExited.AddListener(DroppedGun);
        m_InteractableBase.onActivate.AddListener(TriggerPulled);
        m_InteractableBase.onDeactivate.AddListener(TriggerReleased);
    }

    void TriggerReleased(XRBaseInteractor args) {}

    void TriggerPulled(XRBaseInteractor args)
    {
        FireProjectile();
    }

    void DroppedGun(XRBaseInteractor args) {}

    protected virtual void FireProjectile()
    {
        if (projectile != null && projectileSpawnPoint != null)
        {
            GameObject clonedProjectile = Instantiate(projectile, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            Rigidbody projectileRigidbody = clonedProjectile.GetComponent<Rigidbody>();
            float destroyTime = 0f;
            if (projectileRigidbody != null)
            {
                projectileRigidbody.AddForce(clonedProjectile.transform.forward * projectileSpeed);
                destroyTime = projectileLife;
            }
            Destroy(clonedProjectile, destroyTime);
        }
    }
}