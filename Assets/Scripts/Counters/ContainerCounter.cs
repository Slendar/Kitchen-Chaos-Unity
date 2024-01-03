using UnityEngine;
using System;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            if (!player.HasKitchenObject())
            {
                //Player is not carrying anything
                KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);

                OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
