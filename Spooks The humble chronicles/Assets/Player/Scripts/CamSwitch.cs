using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    private Animator _camAnimator;
    private CamSwitchControls _inputControls;
    private void Awake()
    {
        _inputControls = new CamSwitchControls();
        _inputControls.CamSwitch.CamSwitchPress.performed += ctx => PlayerChangeView(true);
        _inputControls.CamSwitch.CamSwitchPress.canceled += ctx => PlayerChangeView(false);
    }
    private void OnEnable()
    {
        _inputControls.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        _camAnimator = GetComponent<Animator>();
    }
    private void OnDisable()
    {
        _inputControls.Disable();
    }
    private void OnDestroy()
    {
        _inputControls.CamSwitch.CamSwitchPress.performed -= ctx => PlayerChangeView(true);
        _inputControls.CamSwitch.CamSwitchPress.canceled -= ctx => PlayerChangeView(false);
      
    }
    private void PlayerChangeView(bool held)
    {
        _camAnimator.SetBool("switch", held);
    }
}
