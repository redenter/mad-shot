using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;


public class GazeTargetCar : MonoBehaviour, 
IPointerEnterHandler, 
IPointerExitHandler, 
IPointerDownHandler, 
IPointerUpHandler {

	Renderer renderer;
	Renderer TargetColor; 
	Color activeColor = Color.red;
	Color inActiveColor = new Color(.1f,.5f,.5f);


	void SetColor(Color color) {
		//Asset specific. TODO should find better alternatives. bad code
		GameObject carBody = transform.FindChild ("Cube_015").gameObject;
		carBody.GetComponent<Renderer> ().material.color = Color.red;
		Material[] mat = carBody.GetComponent<Renderer> ().materials;
		for (int i=0;i<mat.Length;i++){
			mat[i].SetColor("_Color",color);
		}
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
		SetColor(inActiveColor);
	}

	public void OnPointerUp (PointerEventData eventData) {
		SetColor(inActiveColor);
	}
}
