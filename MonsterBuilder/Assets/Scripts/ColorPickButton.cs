using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPickButton : MonoBehaviour
{
    public UnityEvent<Color> ColorPickerEvent;
    [SerializeField] Texture2D colorChart;
    [SerializeField] GameObject chart;
    [SerializeField] RectTransform cursor;
    [SerializeField] Image button;
    [SerializeField] Image cursorColor;

    public void PickColor(BaseEventData data)
    {
        PointerEventData pointer = data as PointerEventData;
        cursor.position = pointer.position;
        Vector2 cursorRealPosition = new Vector2(transform.GetChild(0).GetComponent<RectTransform>().rect.width / 2 + cursor.localPosition.x, transform.GetChild(0).GetComponent<RectTransform>().rect.height / 2 + cursor.localPosition.y);
        Color pickedColor = colorChart.GetPixel((int)(cursorRealPosition.x * (colorChart.width / transform.GetChild(0).GetComponent<RectTransform>().rect.width)), (int)(cursorRealPosition.y * (colorChart.height / transform.GetChild(0).GetComponent<RectTransform>().rect.height)));
        Debug.Log(pickedColor);
        cursorColor.color = pickedColor;
        ColorPickerEvent.Invoke(pickedColor);
    }
}