using System;
using UnityEngine;

public class LocoMotion : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private string[] _swordSwingAnim;
    [SerializeField] private string[] _magicSpellAnim;
    [SerializeField] private GameObject _swordObject;
    [SerializeField] private GameObject _ShieldObject;
    private MotionInputControls _inputControls;
    private Vector2 _movePlayer;

    private CharacterController _characterController;
    private Animator _animator;
    private bool _isRunning;
    private bool _isFacingRight;

    private bool _isMidAnim;
    private bool _isMidJump;
    private IDealSwordDamage _SwordDamageInterface;
    private IToggleShield _ShieldToggleInterface;
   
    private void Awake()
    {
        _inputControls = new MotionInputControls();

        _inputControls.MotionControls.Move.performed += ctx => _movePlayer = ctx.ReadValue<Vector2>();
        _inputControls.MotionControls.Move.canceled += ctx => _movePlayer = Vector2.zero;
        _inputControls.MotionControls.Jump.performed += ctx => PlayerJump();
        _inputControls.MotionControls.LightSwing.performed += ctx => PlayerLightSwing();
        _inputControls.MotionControls.HeavySwing.performed += ctx => PlayerHeavySwing();
        _inputControls.MotionControls.Fireball.performed += ctx => PlayerFireball();
        _inputControls.MotionControls.Block.performed += ctx => PlayerBlock(true);
        _inputControls.MotionControls.Block.canceled += ctx => PlayerBlock(false);
        _inputControls.MotionControls.Run.performed += ctx => SetRun(true);
        _inputControls.MotionControls.Run.canceled += ctx => SetRun(false);
      
        //_inputControls.MotionControls.HeavySpellOne.performed += ctx => PlayerHeavyOne();
        //_inputControls.MotionControls.HeavySpellTwo.performed += ctx => PlayerHeavyTwo();
        //_inputControls.MotionControls.SheaveSword.performed += ctx => PlayerSheaveSword();
        //_inputControls.MotionControls.SheaveShield.performed += ctx => PlayerSheaveShield();
    }

    // Start is called before the first frame update
    void Start()
    {
        RFX4_PhysicsMotion.GetplayerDirection += GetFireballDirection;
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _SwordDamageInterface = _swordObject.GetComponent<IDealSwordDamage>();
        _ShieldToggleInterface = _ShieldObject.GetComponent<IToggleShield>();
        _inputControls.Enable();
        _isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isMidJump)
        {
            if (_movePlayer.x > 0.3f || _movePlayer.x < -0.3f)
            {
                if (GetControllerDirection().magnitude >= 0.1f)
                {

                    if (!_isRunning)
                        _animator.SetFloat("Walk", 0.5f);
                    else
                        _animator.SetFloat("Walk", 1f);

                    if (_movePlayer.x < 0 && _isFacingRight)
                        Flip();
                    else if (_movePlayer.x > 0 && !_isFacingRight)
                        Flip();

                    _characterController.Move(GetControllerDirection() * speed * Time.deltaTime);

                }
            }
            else
            {
                _animator.SetFloat("Walk", 0f);
            }
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
        _inputControls.MotionControls.Block.performed -= ctx => PlayerBlock(true);
        _inputControls.MotionControls.Block.canceled -= ctx => PlayerBlock(false);
        _inputControls.MotionControls.Run.performed += ctx => SetRun(true);
        _inputControls.MotionControls.Run.canceled += ctx => SetRun(false);
        //_inputControls.MotionControls.ThirdPersonView.performed -= ctx => PlayerChangeView();
        //_inputControls.MotionControls.HeavySpellOne.performed -= ctx => PlayerHeavyOne();
        //_inputControls.MotionControls.HeavySpellTwo.performed -= ctx => PlayerHeavyTwo();
        //_inputControls.MotionControls.SheaveSword.performed -= ctx => PlayerSheaveSword();
        //_inputControls.MotionControls.SheaveShield.performed -= ctx => PlayerSheaveShield();
        RFX4_PhysicsMotion.GetplayerDirection += GetFireballDirection;
    }

    private Vector3 GetControllerDirection()
    {
        Vector3 dir;
        dir.x = _movePlayer.x;
        dir.y = 0;
        dir.z = 0;
        return dir.normalized;
    }

    public Vector3 GetFireballDirection()
    {
        if (_isFacingRight)
            return Vector3.right;
        else
            return Vector3.left;
    }
    //TODO clean up the 180 animation
    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
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

    private void MidJump()
    {
        _isMidJump = !_isMidJump;
    }
    private void PlayerBlock(bool blocking)
    {
        _animator.SetBool("Blocking", blocking);
        _ShieldToggleInterface?.ToggleShieldCollider(blocking);
    }

    private void PlayerFireball()
    {
        _animator.SetTrigger(_magicSpellAnim[0]);
    }

    private void PlayerHeavySwing()
    {
        _animator.SetTrigger(_magicSpellAnim[1]);
    }
    private void EndSwing()
    {
        _isMidAnim = false;
        _SwordDamageInterface?.ToogleSwordCollider(false);
    }
    private void PlayerLightSwing()
    {
        if (!_isMidAnim)
        {
            _SwordDamageInterface?.ToogleSwordCollider(true);
            _animator.SetTrigger(_swordSwingAnim[0]);
        }
        else
        {
           //this is where the combo system will take us
        }
      
    }

    private void PlayerJump()
    {
        _isMidJump = true;
        _animator.SetTrigger("Jump");
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

    
    private void SetRun(bool run)
    {
        _isRunning = run;
        if (_isRunning)
            speed = 6;
        else
            speed = 3;
    }
}
