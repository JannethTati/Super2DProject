using UnityEngine;
using System;


[RequireComponent(typeof(Rigidbody2D))]

public class JetPack : MonoBehaviour
{
    public enum Direction
    {
        Left,
        Right 
    }
    #region Properties
     public float Energy
    { 
        get

          {
            return _energy;
          }

        set

          {
            

             _energy = Mathf.Clamp(value,0,_maxEnergy);
          }
    }
    
    public bool Flying { get; set; }
    #endregion

    #region Fields
    private Rigidbody2D _targetRB;
    [SerializeField] private float _energy;
    [SerializeField] private float _maxEnergy;
    [SerializeField] private float _energyFlyingRatio;
    [SerializeField] private float _energyRegenRatio;
    [SerializeField] private float _horizontalForce;
    [SerializeField] private float _flyForce;
    


    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _targetRB = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Energy = _maxEnergy;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Flying)
            DoFly();

        //Le quitamos el signo a la velocidad si es negativo
        //Luego si es menor de 0.1, consideramos que estamos parados y cargamos
        if(Mathf.Abs(_targetRB.linearVelocity.y) < 0.1f)
            Regenerate();

    }

    #endregion

    #region Unity Methods
    public void FlyUp()
    {
        Flying = true;
    }
    public void StopFlying()
    {
        Flying = false;
    }
    public void Regenerate()
    {
        Energy += _energyRegenRatio;
    }
    public void AddEnergy(float energy)
    {
        Energy += energy;
    }
    public void FlyHorizontal(Direction flyDirection)
    {
        if (!Flying)
            return;

        if (flyDirection == Direction.Left)

            _targetRB.AddForce(Vector2.left * _horizontalForce);
        else
            _targetRB.AddForce(Vector2.right * _horizontalForce);

    }
    #endregion

    #region Private Methods
    private void DoFly()
    {
        if (Energy > 0)
        {

            _targetRB.AddForce(Vector2.up * _flyForce);
            Energy -= _energyFlyingRatio;

        }
        else
           Flying = false;
        
    }

    #endregion
}


