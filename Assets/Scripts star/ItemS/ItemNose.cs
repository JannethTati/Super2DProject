using UnityEngine;
using System;

public class ItemNose : Item
{

    const float NOSE_DAMAGE = -20;

    #region Unity Callbacks

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
            recolected();

        if (collision.gameObject.tag == "Player")

        {
            JetPack jetpack = collision.gameObject.GetComponent<JetPack>();
          
            jetpack.AddEnergy(NOSE_DAMAGE);

            recolected();
           



        }
    }



    
    #endregion


}
