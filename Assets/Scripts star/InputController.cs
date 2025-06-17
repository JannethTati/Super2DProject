using UnityEngine;
using System;

public class InputController : MonoBehaviour
{

    #region Fields
    [SerializeField] private JetPack _jetpack;
    
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal Fly
        if (Input.GetAxis("Horizontal") < 0)
        _jetpack.FlyHorizontal(JetPack.Direction.Left);
        if (Input.GetAxis("Horizontal") > 0)
            _jetpack.FlyHorizontal(JetPack.Direction.Right);
        //Vertical Fly
        if (Input.GetAxis("Vertical") > 0)
            _jetpack.FlyUp();
        else
            _jetpack.StopFlying();
    }
    #endregion
}
