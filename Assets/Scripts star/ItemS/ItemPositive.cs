using UnityEngine;
using System;

public class ItemPositive : Item
{
    #region Contants

    const float POSITIVE_HEAL = 20;

    #endregion

    #region Unity Callbacks
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
            recolected();

        if (collision.gameObject.tag == "Player")

        {
            JetPack jetpack = collision.gameObject.GetComponent<JetPack>();
            
                    jetpack.AddEnergy(POSITIVE_HEAL);
                    recolected();




        }
    }



    #endregion
   


}
