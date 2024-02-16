using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeGameObjectState : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private bool _state;
    public void OnPointerClick(PointerEventData eventData)
    {
        ButtonExit();
    }
    private void ButtonExit()
    {
        _panel.SetActive(_state);
    }
}