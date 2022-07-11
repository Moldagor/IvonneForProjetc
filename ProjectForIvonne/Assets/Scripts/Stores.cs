using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class Stores : MonoBehaviour
{
    private ManagerObject managerObject;

    [SerializeField] GameObject objectStorePrefab;
    [SerializeField] int maxNuemberObjectStore;
    [SerializeField] ObjectClassification[] listObjectStore;
    [SerializeField] List<ObjectClassification> listObjectClassifications;
    [SerializeField] Animator animationInv;
    bool controlAnimation;

    //intanciamos objetos para la tienda y validamos que no se repitan y le permitimos una cantidad maxima de objetos en la tienda 
    private void Start()
    {
        listObjectClassifications.AddRange(listObjectStore);

        for (int i = 0; i <= maxNuemberObjectStore -1; i++)
        {
            GameObject store = GameObject.Instantiate(objectStorePrefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Store").transform);
            int index = Random.Range(0, listObjectClassifications.Count);
            managerObject = store.GetComponent<ManagerObject>();
            managerObject.CreationObject(listObjectClassifications[index]);
            listObjectClassifications.Remove(listObjectClassifications[index]);
        }
        Debug.Log("Ejecucion detro del start Stores");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            controlAnimation = !controlAnimation;
            animationInv.SetBool("IsOpenTienda", controlAnimation);

        }
    }
    public void OnMouseDown()
    {
        Debug.Log("Que estoy precionando 1" + objectStorePrefab);
    }
}

