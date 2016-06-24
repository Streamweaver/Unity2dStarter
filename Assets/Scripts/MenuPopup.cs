using UnityEngine;
using System.Collections;

public class MenuPopup : MonoBehaviour {
	public void Open() {
		gameObject.SetActive (true);
	}
	public void Close() {
		gameObject.SetActive (false);
	}
	public bool IsActive() {
		return gameObject.activeSelf;
	}
}
