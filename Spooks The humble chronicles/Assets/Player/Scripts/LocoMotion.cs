using System;
using UnityEngine;

public class LocoMotion : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private string[] _swordSwingAnim;
    [SerializeField] private string[] _magicSpellAnim;

    private MotionInputControls _inputControls;
    private Vector2 _movePlayer;

    private CharacterController _characterController;
    private Animator _animator;
    private bool _isRunning;
    private bool _isFaceingRight = true;

    private float _comboTime;
    private float _comboTimeLimit = 0.5f;
    private bool _startTimer;
    private bool _isMidAnim;
    private int _swordComboCount;
    private void Awake()
    {
        _inputControls = new MotionInputControls();

        _inputControls.MotionControls.Move.performed += ctx => _movePlayer = ctx.ReadValue<Vector2>();
        _inputControls.MotionControls.Move.canceled += ctx => _movePlayer = Vector2.zero;
        _inputControls.MotionControls.Jump.performed += ctx => PlayerJump();
        _inputControls.MotionControls.LightSwing.performed += ctx => PlayerLightSwing();
        _inputControls.MotionControls.HeavySwing.performed += ctx => PlayerHeavySwing();
        _inputControls.MotionControls.Fireball.performed += ctx => PlayerFireball();
        _inputControls.MotionControls.Block.performed += ctx => PlayerBlock();
        _inputControls.MotionControls.Run.performed += ctx => SetRun(true);
        _inputControls.MotionControls.Run.canceled += ctx => SetRun(false);
        //_inputControls.MotionControls.ThirdPersonView.performed += ctx => PlayerChangeView();
        //_inputControls.MotionControls.HeavySpellOne.performed += ctx => PlayerHeavyOne();
        //_inputControls.MotionControls.HeavySpellTwo.performed += ctx => PlayerHeavyTwo();
        //_inputControls.MotionControls.SheaveSword.performed += ctx => PlayerSheaveSword();
        //_inputControls.MotionControls.SheaveShield.performed += ctx => PlayerSheaveShield();
    }

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _inputControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_startTimer)
        //    _comboTime += Time.deltaTime;
        
        if (_movePlayer.x > 0.3f || _movePlayer.x < -0.3f)
        {
            if (GetDirection().magnitude >= 0.1f)
            {
               
                    if (!_isRunning)
                        _animator.SetFloat("Walk", 0.5f);
                    else
                        _animator.SetFloat("Walk", 1f);

                    if (_movePlayer.x < 0 && _isFaceingRight)
                        Flip();
                    else if (_movePlayer.x > 0 && !_isFaceingRight)
                        Flip();
                if (!_isMidAnim)
                {
                    _characterController.Move(GetDirection() * speed * Time.deltaTime);
                }
            }
        }
        else
        {
            _animator.SetFloat("Walk", 0f);
        }
    }

    private void OnDisable()
    {
        _inputControls.Disable();
    }

    private void OnDestroy()
    {
        _inputControls.MotionControls.Move.performed -= ctx => _movePlayer = ctx.ReadValue<Vector2>();
        _inputControls.MotionControls.Move.canceled -= ctx => _movePlayer = Vector2.zero;
        _inputControls.MotionControls.Jump.performed -= ctx => PlayerJump();
        _inputControls.MotionControls.LightSwing.performed -= ctx => PlayerLightSwing();
        _inputControls.MotionControls.HeavySwing.performed -= ctx => PlayerHeavySwing();
        _inputControls.MotionControls.Fireball.performed -= ctx => PlayerFireball();
        _inputControls.MotionControls.Block.performed -= ctx => PlayerBlock();
        _inputControls.MotionControls.Run.performed += ctx => SetRun(true);
        _inputControls.MotionControls.Run.canceled += ctx => SetRun(false);
        //_inputControls.MotionControls.ThirdPersonView.performed -= ctx => PlayerChangeView();
        //_inputControls.MotionControls.HeavySpellOne.performed -= ctx => PlayerHeavyOne();
        //_inputControls.MotionControls.HeavySpellTwo.performed -= ctx => PlayerHeavyTwo();
        //_inputControls.MotionControls.SheaveSword.performed -= ctx => PlayerSheaveSword();
        //_inputControls.MotionControls.SheaveShield.performed -= ctx => PlayerSheaveShield();

    }

    private Vector3 GetDirection()
    {
        Vector3 dir;
        dir.x = _movePlayer.x;
        dir.y = 0;
        dir.z = 0;
        return dir.normalized;
    }

    private void Flip()
    {
        _isFaceingRight = !_isFaceingRight;
        Quaternion rot = transform.rotation;
        rot.y *= -1;
        transform.rotation = rot;
        //will have to sort this out anopther day
       // _animator.SetTrigger("RotatePlayer");
    }
    private void MidAnimation()
    {
        _isMidAnim = !_isMidAnim;
    }
    private void PlayerBlock()
    {
        throw new NotImplementedException();
    }

    private void PlayerFireball()
    {
        _animator.SetTrigger(_magicSpellAnim[0]);
    }

    private void PlayerHeavySwing()
    {
        _animator.SetTrigger(_magicSpellAnim[1]);
    }

    private void PlayerLightSwing()
    {
        _animator.SetTrigger(_swordSwingAnim[0]);
        //if (_swordComboCount <= _swordSwingAnim.Length && _comboTime <= _comboTimeLimit)
        //{
        //    _animator.SetTrigger(_swordSwingAnim[_swordComboCount]);
        //    _swordComboCount++;
        //    if (!_startTimer)
        //    {
        //        _startTimer = true;
        //        _animator.ResetTrigger("ResetAttack");
        //    }

        //}
        //else
        //{
        //    _comboTime = 0;
        //    _swordComboCount = 0;
        //    _startTimer = false;
        //    for (int i = 0; i < _swordSwingAnim.Length; i++)
        //    {
        //        _animator.ResetTrigger(_swordSwingAnim[i]);
        //    }
        //    _animator.SetTrigger("ResetAttack");
        //}
    }

    private void PlayerJump()
    {
        throw new NotImplementedException();
    }

    private void PlayerSheaveShield()
    {
        throw new NotImplementedException();
    }

    private void PlayerSheaveSword()
    {
        throw new NotImplementedException();
    }

    private void PlayerHeavyTwo()
    {
        throw new NotImplementedException();
    }

    private void PlayerHeavyOne()
    {
        throw new NotImplementedException();
    }

    private void PlayerChangeView()
    {
        throw new NotImplementedException();
    }
    private void SetRun(bool run)
    {
        _isRunning = run;
        if (_isRunning)
            speed = 6;
        else
            speed = 3;
    }
}
