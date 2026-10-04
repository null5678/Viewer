using TMPro;
using UnityEngine;

public class EquipmentStatusView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _nameText;
    
    [SerializeField]
    private TextMeshProUGUI _attackText;
    
    [SerializeField]
    private TextMeshProUGUI _defenceText;

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
