using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] List<BasicObject> objetosObtenidos = new List<BasicObject>();
    public void PickUp(BasicObject objeto)
    {
        objetosObtenidos.Add(objeto);
        Debug.Log("obtuve un objeto, tengo: " + objetosObtenidos.ToArray().Length);
    }
}
