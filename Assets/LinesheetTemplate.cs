using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LinesheetTemplate : MonoBehaviour
{
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;
    }

    public void Show(float fadeDuration)
    {
        DOTween.Kill(_canvasGroup);
        _canvasGroup.DOFade(1.0f, fadeDuration);
    }

    public void Hide(float fadeDuration, float delay)
    {
        DOTween.Kill(_canvasGroup);
        DOVirtual.DelayedCall(delay, () => { _canvasGroup.DOFade(0.0f, fadeDuration); })
            .SetTarget(_canvasGroup);
    }


}
