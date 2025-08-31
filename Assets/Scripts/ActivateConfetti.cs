using UnityEngine;

public class ActivateConfetti : MonoBehaviour
{
    [SerializeField] private ParticleSystem confettiParticles;
    public void TriggerConfetti(bool triggered)
    {
        if (!triggered) {return; }
        confettiParticles.Play();
    }
}
