using System;
using UnityEngine;

public class LocoMotion : MonoBehaviour
{
    [SerializeField] private float speed = 6f;

    private MotionInputControls _inputControls;
    private Vector2 _movePlayer;

    private CharacterController _characterController;
    private Animator _animator;


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
        if (_movePlayer.x > 0.3f || _movePlayer.x < -0.3f)
        {
            if (GetDirection().magnitude >= 0.1f)
            {
                _characterController.Move(GetDirection() * speed * Time.deltaTime);
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

    }
    private void PlayerBlock()
    {
        throw new NotImplementedException();
    }

    private void PlayerFireball()
    {
        throw new NotImplementedException();
    }

    private void PlayerHeavySwing()
    {
        throw new NotImplementedException();
    }

    private void PlayerLightSwing()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}
