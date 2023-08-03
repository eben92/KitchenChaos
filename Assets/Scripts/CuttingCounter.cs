using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    public override void Interact(Player player)
    {

        if (!HasKitchenObject())
        {
            // theres no kitchenObject here

            if (player.HasKitchenObject())
            {
                // player is carrying a kitchen object
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // player is not carrying a kitchen object

            }

        }
        else
        {
            // there is a kitchen object
            if (player.HasKitchenObject())
            {
                // player is carrying something
            }
            else
            {
                // player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);

            }
        }

    }
}
