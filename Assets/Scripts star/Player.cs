using UnityEngine;
using System;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    #region Fields 
    [SerializeField] private JetPack _jetpack;
    private Animator _anim;
    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_jetpack.Flying)
            _anim.SetBool("Flying", _jetpack.Flying);
    }

    #endregion
}
