using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterBehaviours : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject lightentity;
    public GameObject dankentity;

    private PlayerInput _playerInput;
    private PlayerControls _pc;

    public bool ghost = false;

    public float playerspeed = 10.0f;



    // Start is called before the first frame update
    private void Awake()
    {
        _pc = new PlayerControls();

        //grab player input
        _playerInput = GetComponent<PlayerInput>();

        

        //init out input actions
        InitInputActions();

        if (rb == null)
        {
           rb = GetComponent<Rigidbody2D>();
        }
        
    }

    private void OnEnable()
    {
        _pc.Enable();
    }

    private void OnDisable()
    {
        _pc.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void InitInputActions()
    {
        _pc.WorldMovement.Movement.performed += ctx => PlayerMove(ctx.ReadValue<Vector2>());
        _pc.WorldMovement.Movement.canceled += ctx => PlayerMove(ctx.ReadValue<Vector2>());
    }

    private void PlayerMove(Vector2 MovenemtDir = new Vector2())
    {
        

        rb.velocity = MovenemtDir * (playerspeed);
    }


}
