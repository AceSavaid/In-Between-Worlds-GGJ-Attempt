using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Switch : MonoBehaviour
{
    public GameObject lightentity;
    public GameObject darkentity;

    private PlayerInput _playerInput;
    private PlayerControls _pc;

    public bool alt = false;
    private bool switchlock = false;



    private void OnEnable()
    {
        _pc.Enable();
    }

    private void OnDisable()
    {
        _pc.Disable();
    }

    private void Awake()
    {
        _pc = new PlayerControls();

        //grab player input
        _playerInput = GetComponent<PlayerInput>();



        //init out input actions
        InitInputActions();

    }

    // Update is called once per frame
    void Update()
    {
        //if nothing is stopping if from switching
        if (!switchlock)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SwitchWorlds();
            }
        }
        
    }

    private void InitInputActions()
    {
        _pc.WorldMovement.Switch.performed += ctx => SwitchWorlds();
        
    }

    public void SwitchWorlds()
    {
        if (alt == false)
        {
            darkentity.gameObject.SetActive(true);
            lightentity.gameObject.SetActive(false);
            alt = true;
        }
        else if (alt == true)
        {
            darkentity.gameObject.SetActive(false);
            lightentity.gameObject.SetActive(true);

            alt = false;
        }
    }
}
