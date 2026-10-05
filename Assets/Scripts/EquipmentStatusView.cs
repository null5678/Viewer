using TMPro;
using UnityEngine;

/// <summary>
/// ステータスビュー
/// </summary>
public class EquipmentStatusView : MonoBehaviour
{
    /// <summary>
    /// 名前テキスト
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _nameText;
    
    /// <summary>
    /// 攻撃テキスト
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _attackText;
    
    /// <summary>
    /// 防御テキスト
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _defenceText;

    /// <summary>
    /// セットアップ
    /// </summary>
    /// <param name="name">装備名</param>
    /// <param name="attack">攻撃力</param>
    /// <param name="defence">防御力</param>
    public void Setup(
        string name,
        int attack,
        int defence)
    {
        if (_nameText != null)
        {
            _nameText.text = name;
        }

        if (_attackText != null)
        {
            _attackText.text = attack.ToString();
        }

        if (_defenceText != null)
        {
            _defenceText.text = defence.ToString();
        }
    }
}
