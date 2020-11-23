using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAttackScript : MonoBehaviour
{
    [SerializeField] private Animator _attackAnimator;
    [SerializeField] private GameObject _SwordObject;
    [SerializeField] private float _ComboTime = 1;
    [SerializeField] private string[] _AttackNames;
    private ButtonInputController _PlayerButtonInput;
    private int _buttonPressCount = 0;
   
    private float _DeltaTime;
    private Queue<string> _animTagQueue;
    private LocoMotion _movementScript;
    private bool _isHeavyattack;
    private void Awake()
    {
         _movementScript = GetComponentInParent<LocoMotion>();
        _PlayerButtonInput = new ButtonInputController();
        _animTagQueue = new Queue<string>();
    }

    private void OnEnable()
    {
        _PlayerButtonInput.ButtonInput.SquareButton.performed += ctx => SwordAttack();
        _PlayerButtonInput.ButtonInput.TriangleButton.performed += ctx => HeavySpellAttack();
        _PlayerButtonInput.ButtonInput.CircleButton.performed += ctx => SpellAttack();
        _PlayerButtonInput.Enable();
    }
    private void OnDisable()
    {
        _PlayerButtonInput.ButtonInput.SquareButton.performed -= ctx => SwordAttack();
        _PlayerButtonInput.ButtonInput.TriangleButton.performed -= ctx => HeavySpellAttack();
        _PlayerButtonInput.ButtonInput.CircleButton.performed -= ctx => SpellAttack();
        _PlayerButtonInput.Disable();
    }

    private void SwordAttack()
    {
        switch (_buttonPressCount)
        {
            case 0:
             
                StartCoroutine(StartComboTimer(_AttackNames[_buttonPressCount]));
                _buttonPressCount++;
                break;
            case 1:
                if(_ComboTime >= _DeltaTime)
                {
                    _animTagQueue.Enqueue(_AttackNames[_buttonPressCount]);
                    _buttonPressCount++;
                }
                break;
            case 2:
                if (_ComboTime >= _DeltaTime)
                {
                    _animTagQueue.Enqueue(_AttackNames[_buttonPressCount]);
                    _buttonPressCount++;
                }
                break;
            default:
                break;
        }
    }

    private void SpellAttack()
    {
        if (_buttonPressCount == 0)
            _attackAnimator.SetTrigger("FireBallSpell");
    }

    private void HeavySpellAttack()
    {
        if (_buttonPressCount >= 2)
        {
            if (_ComboTime >= _DeltaTime)
            {
                _animTagQueue.Enqueue(_AttackNames[_buttonPressCount + 1]);
            }
        }
    }
    private void ResetComboMachine()
    {
        _DeltaTime = 0;
        _buttonPressCount = 0;
    }
    private void HeavyattackMovement()
    {
        _isHeavyattack = !_isHeavyattack;
        _movementScript.OnMidAnimation(_isHeavyattack);
    }
    private void FinishedJumping()
    {
        _movementScript.MidJump(false);
    }
    private void OnAttackStarted()
    {
        _SwordObject.SetActive(true);
    }
    private void OnNextAnimation()
    {
        _SwordObject.SetActive(false);
        if (_animTagQueue.Count == 0)
            _attackAnimator.SetTrigger("ResetCombo");
        else
            _attackAnimator.SetTrigger(_animTagQueue.Dequeue());
        
       
    }
    private IEnumerator StartComboTimer(string animName)
    {
        _attackAnimator.SetTrigger(animName);
        while (_ComboTime >= _DeltaTime)
        {
            _DeltaTime += Time.deltaTime;
            yield return 0;
        }
        yield return 0;
        ResetComboMachine();
    }

}
