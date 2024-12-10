using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ParticlePlayOnUse : MonoBehaviour
{
    // if interactable object with particles as child is grabbed and used,
    // particles start playing
    // and stop when interactable is not used

    public ParticleSystem particles;

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartParticles());
        grabInteractable.deactivated.AddListener(x => StopParticles());
    }

    public void StartParticles()
    {
            particles.Play();
    }

    public void StopParticles()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
}