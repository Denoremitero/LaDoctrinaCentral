using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] List<int> objetosObtenidos = new List<int>();
    public void PickUp()
    {
        objetosObtenidos.Add(1);
        Debug.Log("obtuve un objeto, tengo: " + objetosObtenidos.ToArray().Length);
    }
}
