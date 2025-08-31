using UnityEngine;

public class ActivateConfetti : MonoBehaviour
{

    [SerializeField] private ParticleSystem confettiParticles;

  

    public void TriggerConfetti(bool trigerd)
    {

        if (!trigerd) {return; }

        confettiParticles.Play();
    }
}
