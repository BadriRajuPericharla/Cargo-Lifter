using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trig : MonoBehaviour
{
    [SerializeField] private CraneRotate craneRotate;
    [SerializeField] private Hook hook;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hook") && hook.cargoStack.Count == 0 && hook.totalCargoReleased == 0)
        {
            craneRotate.RotateReverse();
        }
    }



}
