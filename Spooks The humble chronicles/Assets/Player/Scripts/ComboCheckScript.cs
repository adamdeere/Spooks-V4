using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCheckScript : MonoBehaviour
{
    public static CheckComboAnimation OnCheckAnim = delegate{}; 
    
    public void AttackAnimationFinished()
    {
        OnCheckAnim();
    }
}
