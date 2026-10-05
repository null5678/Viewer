using System;
using UnityEngine;

public class EquipmentSceneManeger : MonoBehaviour
{
    [SerializeField]
    private EquipmentListPresenter _equipmentListPresenter;
    
    private void Start()
    {
        _equipmentListPresenter.Initialize();
    }
}
