using UnityEngine;
using System;

public class Item : MonoBehaviour, IRecoletable
{
    #region Contants
    
   
    

    #endregion


    public enum ItemTypes
    {
        None,
        NoSe,
        ErrorCode,
        PositiveWords

    }

    #region Properties
    [field: SerializeField] public ItemTypes Type { get; set; }
    #endregion

    #region Fields
    [SerializeField] private GameObject _particles;
    #endregion


    #region public Methods
    public virtual void recolected()
       {

        Destroy(gameObject);
        CreateParticles();

       }
    #endregion

    #region public Methods

    private void CreateParticles()
    {

        Instantiate(_particles, transform.position, Quaternion.identity);
    
    }

    #endregion

}
