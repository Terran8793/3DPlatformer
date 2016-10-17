using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GameObject levelButtonPrefab;
	public GameObject levelButtonContainer;

	private void Start()
	{
		Sprite[] thumbnails = Resources.LoadAll<Sprite> ("Levels");
	}
}
