using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public static class AnimationHelper
{
    public static void OpenPopupAnimation(Transform popup,System.Action callback = null) {
        popup.localScale = Vector3.zero;
        popup.gameObject.SetActive(true);
        popup.DOScale(1f, 0.5f).SetEase(Ease.OutBack).onComplete += () => {
            callback?.Invoke();
        };
    }
}
