using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {
	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		ItemInfo myInfo = gameObject.GetComponent<ItemInfo> ();
		ItemInfo dropInfo = DragAndDrop.itemBeingDragged.GetComponent<ItemInfo> ();


			DragAndDrop.itemBeingDragged.GetComponent<RectTransform> ().anchoredPosition = DragAndDrop.itemBeingDragged.GetComponent<RectTransform> ().anchoredPosition;
	
		
	}

	#endregion
	}
