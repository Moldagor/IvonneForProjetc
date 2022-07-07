using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stores : MonoBehaviour
{
    private ManagerObject managerObject;

    [SerializeField] GameObject objectStorePrefab;
    [SerializeField] int maxNuemberObjectStore;
    [SerializeField] ObjectClassification[] listObjectStore;
    [SerializeField] List<ObjectClassification> listObjectClassifications;
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
    }
}
