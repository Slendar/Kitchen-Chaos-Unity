using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateIconsUI : MonoBehaviour
{
    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private PlateIconSingleUI iconTameplate;

    private void Awake()
    {
        iconTameplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;
    }

    private void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
        UpdateVisual(e.kitchenObjectSO);
    }

    private void UpdateVisual(KitchenObjectSO kitchenObjectSO)
    {
        /*foreach(KitchenObjectSO kitchenObjectSO in plateKitchenObject.GetKitchenObjectSOList())
        {*/
            Transform iconTransform = Instantiate(iconTameplate.transform, transform);
            iconTransform.gameObject.SetActive(true);
            iconTameplate.SetKitchenObjectSO(kitchenObjectSO);
        //}
    }
}
