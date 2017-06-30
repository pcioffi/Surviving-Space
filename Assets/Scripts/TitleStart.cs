using UnityEngine;
using System.Collections;

public class TitleStart : MonoBehaviour {
	public string startLevel;

	public void NewGame(){
		Application.LoadLevel (startLevel);
	}
}
