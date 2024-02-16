using UnityEngine;
using UnityEngine.EventSystems;
public class ImageOnClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        ItemDestroy();
    }
    private void ItemDestroy()
    {
        Destroy(gameObject);
    }
}
