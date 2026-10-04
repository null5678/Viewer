using System;
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 装備データ
/// </summary>
[CreateAssetMenu(fileName = "EquipmentData", menuName = "Scriptable Objects/EquipmentData")]
public class EquipmentData : ScriptableObject
{
    [Serializable]
    public struct EquipmentParametor
    {
        /// <summary>
        /// 装備名
        /// </summary>
        public string Name;

        /// <summary>
        /// 攻撃力
        /// </summary>
        public int Attack;

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defence;
    
        /// <summary>
        /// 装備モデルプレハブ
        /// </summary>
        public GameObject ModelPrefab;
    }
    
    public List<EquipmentParametor> Parametors;
}
