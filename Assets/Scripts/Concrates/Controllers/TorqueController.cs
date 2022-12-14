using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueController : MonoBehaviour
{
    [SerializeField] Rotator _rotator;
    ConstantForce _setTorque;
    private void Awake()
    {
        _rotator = Resources.Load("ScriptableObjects/Rotators/RotatorStick") as Rotator;
        _setTorque = GetComponent<ConstantForce>();
    }
    private void Start()
    {
        _setTorque.torque = _rotator._torque;
    }
}
