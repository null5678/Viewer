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
    
    [SerializeField]
    private Button _button;

    private Subject<int> _onButtonClick = new Subject<int>();
    public IObservable<int> OnButtonClick => _onButtonClick;
    
    /// <summary>
    /// セットアップ
    /// </summary>
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
