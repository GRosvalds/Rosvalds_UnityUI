using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop2 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	private RectTransform rectTransform;
	private Image image;
	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta;

	}
	#endregion

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		image.color = new Color32 (255, 255, 255, 10);
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		image.color = new Color32 (255, 255, 255, 0);
	}

	#endregion
	void Start () {
		rectTransform = GetComponent<RectTransform>();
		image = GetComponent<Image> ();
	}



}