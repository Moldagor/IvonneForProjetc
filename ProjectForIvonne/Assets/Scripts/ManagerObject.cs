using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ManagerObject : MonoBehaviour
{
    [SerializeField] Image imageObject;
    [SerializeField] TextMeshProUGUI textNameObject;
    [SerializeField] TextMeshProUGUI textPriceObject;

    private int price;
    private ManagerInventory managerInventory;

    private void Awake()
    {
        managerInventory = FindObjectOfType<ManagerInventory>();
    }
    //funcion para crear objetos en la tienda 
    public void CreationObject(ObjectClassification objectClassification)
    {
        price = objectClassification.priceObject;
        imageObject.sprite = objectClassification.spriteObject;
        textNameObject.text = objectClassification.nameObject;
        textPriceObject.text = objectClassification.priceObject.ToString();
    }
    public void Update()
    {
        managerInventory = FindObjectOfType<ManagerInventory>();
    }
    public void BuyItem()
    {
        managerInventory.AddObjectInventory(price, imageObject);
    }
}
