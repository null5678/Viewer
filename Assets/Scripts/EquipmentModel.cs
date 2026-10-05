using UnityEngine;

public class EquipmentModel : MonoBehaviour
{
    [SerializeField]
    private EquipmentData _equipmentData;
    public EquipmentData EquipmentData => _equipmentData;
}
