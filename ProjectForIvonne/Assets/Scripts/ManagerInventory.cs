using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Animator))]
public class ManagerInventory : MonoBehaviour
{
    private int numberMaxInventory = 0;
    [SerializeField] int capacityInventory;
    [SerializeField] int allMoney = 1000;
    [SerializeField] TextMeshProUGUI textMoney;
    [SerializeField] GameObject objectInventory;
    [SerializeField] Animator animationInv;
    [SerializeField] Stores stores;
    [SerializeField] List<ObjectClassification> listObjectInv = new List<ObjectClassification>();

    bool controlAnimation;

    private void Start()
    {

        textMoney.text = allMoney.ToString();
    }
    //adicionamos objetos al inventarios 
    public void AddObjectInventory(int money, Image imageObject)
    {
        if (money <= allMoney && numberMaxInventory <= capacityInventory)
        {
            allMoney -= money;
            numberMaxInventory++;
            GameObject inventory = GameObject.Instantiate(objectInventory, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Inventory").transform);
            Image image = inventory.GetComponent<Image>();
            image.sprite = imageObject.sprite;
            textMoney.text = allMoney.ToString();
                 
           // listObjectInv.Add(stores.);
           // Debug.Log("listObjectInv" + listObjectInv);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            controlAnimation = !controlAnimation;
            animationInv.SetBool("IsOpenInventario", controlAnimation);

        }
    }
    public void OnMouseDown()
    {
        Debug.Log("Que estoy precionando 2" + objectInventory);
    }
    public void InstantiateItemInventory()
    {
        
    }
}
