using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GUIController : MonoBehaviour {

	[SerializeField] private MenuPopup menuPopup;

	void Start() {
		menuPopup.Close ();
	}

	public void OnMainMenuClick () {
		if (menuPopup.IsActive ()) {
			menuPopup.Close ();
		} else {
			menuPopup.Open ();
		}
	}

	public void QuitRequest() {
		Application.Quit ();
	}

	public void LoadLevel(string name) {
		SceneManager.LoadScene (name);
	}
}
