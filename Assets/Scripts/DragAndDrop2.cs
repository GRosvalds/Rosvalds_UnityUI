using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop2 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler {

	private RectTransform rectTransform;
	private Image image;
	private CanvasGroup canvasGroup;

	[SerializeField] private Canvas Canvas;
	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta/ Canvas.scaleFactor;

	}
	#endregion

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		image.color = new Color32 (255, 255, 255, 10);
		canvasGroup.blocksRaycasts = false;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		image.color = new Color32 (255, 255, 255, 0);
		canvasGroup.blocksRaycasts = true;
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion

	#endregion
	void Start () {
		rectTransform = GetComponent<RectTransform>();
		image = GetComponent<Image> ();
		canvasGroup = GetComponent<CanvasGroup> ();
	}



}