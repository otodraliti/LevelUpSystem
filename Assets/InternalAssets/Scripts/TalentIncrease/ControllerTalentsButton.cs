using UnityEngine;

public class ControllerTalentsButton : MonoBehaviour
{
    private ModelButtonTalents _modelButton;
    private ITalentButtonsView _buttonsView;

    private void Start()
    {
        _modelButton = new ModelButtonTalents();
        _buttonsView = GetComponent<ITalentButtonsView>();
        //_buttonsView.Init(this);
    }
    
    public void AddTalentPoint()
    {
       _modelButton.AddTalentPoint();
       _buttonsView.UpdateText(_modelButton.GetTalentPoints());
    }

    public void ReciveTalentPoint(int amount)
    {
        _modelButton.ReciveTalentPoint(amount);   
        _buttonsView.UpdateText(_modelButton.GetTalentPoints());
    }

    public void RemoveAllPoints()
    {
       // TalentController.current.ResetAllTalents();
        _buttonsView.UpdateText(_modelButton.GetTalentPoints());
    }

    public void RemoveTalentPoint(int amount)
    {
        if ((!_modelButton.RemoveTalentEnable(amount))) return;
        _modelButton.RemoveTalentPoint(amount);
        _buttonsView.UpdateText(_modelButton.GetTalentPoints());
    }
}
