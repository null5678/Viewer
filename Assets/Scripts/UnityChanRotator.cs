using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Unityちゃんを回転
/// </summary>
public class UnityChanRotator 
    : MonoBehaviour, IDragHandler
{
    /// <summary>
    /// 回転対象モデル
    /// </summary>
    [SerializeField]
    private Transform _targetModel;
    
    /// <summary>
    /// 回転スピード
    /// </summary>
    [SerializeField]
    private float _rotateSpeed;

    /// <summary>
    /// ドラッグで回転させる
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        if (_targetModel == null)
        {
            return;
        }
        
        // ドラッグで回転
        float rotateAmount = -eventData.delta.x * _rotateSpeed;
        _targetModel.Rotate(0f, rotateAmount, 0f, Space.World);
    }
}
