using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 装備アイコンビュー
/// </summary>
public class EquipmentIconView : MonoBehaviour
{
    /// <summary>
    /// 名前テキスト
    /// </summary>
    [SerializeField] 
    private TextMeshProUGUI _nameText;
    
    /// <summary>
    /// ボタン
    /// </summary>
    [SerializeField]
    private Button _button;
    
    /// <summary>
    /// ボタン通知
    /// </summary>
    private Subject<int> _onButtonClick = new Subject<int>();
    public IObservable<int> OnButtonClick => _onButtonClick;
    
    /// <summary>
    /// セットアップ
    /// </summary>
    /// <param name="name">名前</param>
    /// <param name="index">リストインデックス</param>
    public void Setup(
        string name,
        int index)
    {
        if (_nameText == null)
        {
            return;
        }
        
        _nameText.text = name;
        
        _button.OnClickAsObservable()
            .Subscribe(_ => _onButtonClick.OnNext(index))
            .AddTo(this);
    }
}
