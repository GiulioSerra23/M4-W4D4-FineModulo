using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAnimationEvents : MonoBehaviour
{
    private SurfaceImpactAudioController _surfaceAudioController;

    public void OnFootStep()
    {
        if (_surfaceAudioController == null) _surfaceAudioController = GetComponentInParent<SurfaceImpactAudioController>();
        _surfaceAudioController.OnFootStep();
    }

    public void OnLanding()
    {
        if (_surfaceAudioController == null) _surfaceAudioController = GetComponentInParent<SurfaceImpactAudioController>();
        _surfaceAudioController.OnLanding();
    }

    public void OnLeverPulled()
    {
        AudioManager.Instance.Play(SoundID.PULL_LEVER);
    }
}
