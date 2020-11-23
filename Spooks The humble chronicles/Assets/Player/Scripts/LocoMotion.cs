using System.Collections;
using UnityEngine;

public class LocoMotion : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    
    private MotionInputControls _inputControls;
    private Vector2 _movePlayer;

    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animator;
 
    private bool _isRunning;
    private bool _isFacingRight;

    private bool _isMidAnim;
    private bool _isMidJump;

    [SerializeField] private float _ComboTime;
  
   
    private void Awake()
    {
        _inputControls = new MotionInputControls();
        _inputControls.MotionControls.Move.performed += ctx => _movePlayer = ctx.ReadValue<Vector2>();
        _inputControls.MotionControls.Move.canceled += ctx => _movePlayer = Vector2.zero;
        _inputControls.MotionControls.Jump.performed += ctx => PlayerJump();
        RFX4_PhysicsMotion.GetplayerDirection += GetFireballDirection;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        _inputControls.Enable();
        _isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isMidJump && !_isMidAnim)
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
        _inputControls.MotionControls.Run.performed -= ctx => SetRun(true);
        _inputControls.MotionControls.Run.canceled -= ctx => SetRun(false);
        RFX4_PhysicsMotion.GetplayerDirection -= GetFireballDirection;
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
        //_animator.SetTrigger("RotatePlayer");
    }
   

    private void MidJump()
    {
        _isMidJump = !_isMidJump;
    }
   
    public void OnMidAnimation(bool anim)
    {
        _isMidAnim = anim;
    }
    private void PlayerJump()
    {
        _animator.SetTrigger("Jump");
    }
    
    private void SetRun(bool run)
    {
        _isRunning = run;
        if (_isRunning)
            speed = 6;
        else
            speed = 1.5f;
    }
}
