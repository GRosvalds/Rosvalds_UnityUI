using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler {

	private RectTransform rectTransform;
	private Image image;


private CanvasGroup canvasGroup;

	static public GameObject itemBeingDragged;
	static public ItemInfo tmpInfo;

	[SerializeField] private Canvas Canvas;
	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData)
	{
		itemBeingDragged.transform.position = eventData.position;

	}
	#endregion

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		GameObject duplicate = Instantiate (gameObject);
		itemBeingDragged = duplicate;
		RectTransform tmpRT = gameObject.GetComponent<RectTransform> ();

		RectTransform rt = itemBeingDragged.GetComponent<RectTransform> ();
		rt.sizeDelta = new Vector2 (tmpRT.sizeDelta.x, tmpRT.sizeDelta.y);

		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		tmpInfo = GetComponent<ItemInfo> ();
		Transform canvas = GameObject.FindGameObjectWithTag ("UI Canvas").transform;
		itemBeingDragged.transform.SetParent (canvas);
		itemBeingDragged.GetComponent<CanvasGroup> ().blocksRaycasts = false;

		

	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		//Destroy (DragAndDrop.itemBeingDragged);
		//DragAndDrop.itemBeingDragged = null;


	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion

	#endregion
	/*void Start () {
		rectTransform = GetComponent<RectTransform>();
		image = GetComponent<Image> ();
		canvasGroup = GetComponent<CanvasGroup> ();
	}
	*/


}
