using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZeroController : MonoBehaviour
{
    private InputMaster _actionsDefinitions;

    private void Awake()
    {
        _actionsDefinitions = new InputMaster();
    }

    #region Initial_Methods
    // Start is called before the first frame update
    void Start()
    {
            
    }
    #endregion
    
    #region ON_Methods
        private void OnEnable()
        {
            _actionsDefinitions.Enable();
        }

        private void OnDisable()
        {
           _actionsDefinitions.Disable();
        }

    #endregion

    #region UdpateMethods    
    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    

    
}
