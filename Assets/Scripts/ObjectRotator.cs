using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// オブジェクトを回転
/// </summary>
public class ObjectRotator 
    : MonoBehaviour, IDragHandler
{
    /// <summary>
    /// 回転対象オブジェクト
    /// </summary>
    [SerializeField]
    private Transform _targetObject;
    
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
        if (_targetObject == null)
        {
            return;
        }
        
        // ドラッグで回転
        float rotateAmount = -eventData.delta.x * _rotateSpeed;
        _targetObject.Rotate(0f, rotateAmount, 0f, Space.World);
    }
}
