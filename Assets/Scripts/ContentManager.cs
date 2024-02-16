using UnityEngine;
using UnityEngine.UI;
public class ContentManager : MonoBehaviour
{
    [SerializeField] private GameObject _contentPrefab;
    [SerializeField] Transform _parentTransform;
    void Start()
    {
        CreateContent();
    }
    private void CreateContent()
    {
        GameObject go;
        int countObject = Random.Range(10, 15);
        for (var i = 0; i < countObject; i++)
        {
            go=Instantiate(_contentPrefab,_parentTransform);
            go.GetComponent<Image>().color = CreateRandomColor();
        }

    }
   private Color CreateRandomColor()
    {
        Color rColor = Color.black;
        while (rColor.r + rColor.g + rColor.b < 1.0f)
        {
            rColor = new Color(Random.value, Random.value, Random.value);
        }
        return rColor;
    }
}
