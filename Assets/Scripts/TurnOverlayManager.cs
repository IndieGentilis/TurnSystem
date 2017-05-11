using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOverlayManager : MonoBehaviour {

    public  void DisableBoolAnimator (Animator anim)
    {
        anim.SetBool("isDisplayed", false);
    }
    public  void EnableBoolAnimator(Animator anim)
    {
        anim.SetBool("isDisplayed", true);
    }
}
