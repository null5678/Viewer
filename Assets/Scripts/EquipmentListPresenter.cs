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
    
    /// <summary>
    /// 装備アイコンリストのルート
    /// </summary>
    [SerializeField] 
    private Transform _equipmentListContent;
    
    /// <summary>
    /// ステータスビュー
    /// </summary>
    [SerializeField]
    private EquipmentStatusView _equipmentStatusView;
    
    /// <summary>
    /// モデル
    /// </summary>
    [SerializeField] 
    private EquipmentModel _model;
    
    /// <summary>
    /// 任意の装備モデルが生成されるところ
    /// </summary>
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
            // 最初のやつでステータス表示させておく
            if (i == 0)
            {
                UpdateStatusView(parametor);
            }
            var iconView = Instantiate(_iconView, _equipmentListContent);
            iconView.Setup(parametor.Name, i);
            iconView.OnButtonClick
                .Subscribe(index =>
                {
                    UpdateStatusView(parametor);
                }).AddTo(iconView);
        }
    }
    
    /// <summary>
    /// ステータスビュー更新
    /// </summary>
    /// <param name="parametor">対象のパラメータ</param>
    private void UpdateStatusView(EquipmentData.EquipmentParametor parametor)
    {
        _equipmentStatusView.Setup(parametor.Name, parametor.Attack, parametor.Defence);

        if (_currentEquipment != null)
        {
            Destroy(_currentEquipment);
        }
                    
        var equipment = Instantiate(parametor.ModelPrefab, _equipmentRoot);
        _currentEquipment = equipment;
    }
}
