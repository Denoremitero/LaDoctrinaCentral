using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] List<BasicObject> objetosObtenidos = new List<BasicObject>();
    [SerializeField] Animator animator;
    [SerializeField] LevelManager levelManager;

    public void PickUp(BasicObject objeto)
    {
        objetosObtenidos.Add(objeto);
        Debug.Log("obtuve un objeto, tengo: " + objetosObtenidos.ToArray().Length);
        animator.SetTrigger("IsGrabbing");

        levelManager.UpdateCantidadObjetos(objetosObtenidos.ToArray().Length);
    }

}
