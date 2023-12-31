using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private Transform counterTopPoint;
    private KitchenObject kitchenObject;


    public virtual void Interact(Player player) { }
    public virtual void InteractAlternate(Player player) {
        Debug.Log("InteractAlternate");
    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    public KitchenObject GetKitchenObject()
    {
        return this.kitchenObject;
    }
    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
    public void ClearKitchenObject()
    {
        this.kitchenObject = null;
    }
    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

}
