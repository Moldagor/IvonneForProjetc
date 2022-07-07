using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject para la creacion de Objetos 
[CreateAssetMenu(fileName ="Object",menuName = "ObjectStore" )]
public class ObjectClassification : ScriptableObject
{
    public Sprite spriteObject;
    public string nameObject;
    public int priceObject;
}
