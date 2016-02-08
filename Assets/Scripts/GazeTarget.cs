using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;


public class GazeTarget : MonoBehaviour, 
IPointerEnterHandler, 
IPointerExitHandler, 
IPointerDownHandler, 
IPointerUpHandler {

	Renderer renderer;
	Renderer TargetColor; 
	Color activeColor = Color.green;
	Color inActiveColor = Color.grey;
	Color clickedColor = Color.red;


	void SetColor(Color color) {
		renderer.material.color = color; 
	}

	void Awake () {
		renderer = GetComponent<Renderer> ();
	}

	void Start () {
		SetColor(inActiveColor);
	}

	public void OnPointerEnter (PointerEventData eventData) {
		SetColor(activeColor);
	}

	public void OnPointerExit (PointerEventData eventData) {
		SetColor(inActiveColor);
	}

	public void OnPointerDown (PointerEventData eventData) {
		SetColor(clickedColor);
	}

	public void OnPointerUp (PointerEventData eventData) {
		SetColor(inActiveColor);
	}
}
