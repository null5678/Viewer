using UniRx;
using UnityEngine;

/// <summary>
/// 装備リストのプレゼンター
/// </summary>
public class EquipmentListPresenter : MonoBehaviour
{
    /// <summary>
    /// 装備リストのアイコンビュー
    /// </summary>
    [SerializeField]
    private EquipmentIconView _iconView;

    [SerializeField] 
    private Transform _equipmentListContent;
    
    [SerializeField]
    private EquipmentStatusView _equipmentStatusView;

    [SerializeField] 
    private EquipmentModel _model;

    [SerializeField] 
    private Transform _equipmentRoot;
    
    /// <summary>
    /// 現在の装備
    /// </summary>
    private GameObject _currentEquipment;
    
    /// <summary>
    /// 初期化
    /// </summary>
    public void Initialize()
    {
        int count = _model.EquipmentData.Parametors.Count;
        if (count == 0)
        {
            return;
        }
        
        for (int i = 0; i < count; i++)
        {
            var parametor = _model.EquipmentData.Parametors[i];
            var iconView = Instantiate(_iconView, _equipmentListContent);
            iconView.Setup(parametor.Name, i);
            iconView.OnButtonClick
                .Subscribe(index =>
                {
                    _equipmentStatusView.Setup(parametor.Name, parametor.Attack, parametor.Defence);

                    if (_currentEquipment != null)
                    {
                        Destroy(_currentEquipment);
                    }
                    
                    var equipment = Instantiate(parametor.ModelPrefab, _equipmentRoot);
                    _currentEquipment = equipment;
                }).AddTo(iconView);
        }
    }
}
