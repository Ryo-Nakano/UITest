using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI扱う

public class ManagerScript : MonoBehaviour {

	InputField inputField;
	[SerializeField] Text nowText;
	[SerializeField] Text savedText;

	// Use this for initialization
	void Start () {
		inputField = GameObject.Find("InputField").GetComponent<InputField>();
	}
	

    //InputFieldが編集される度に呼ばれる
	public void ChangeValue()
	{
		string inputValue = inputField.text;
		nowText.text = inputValue;
	}

    //保存ボタン押した時に呼ばれる関数
	public void SaveButton()
	{
		string inputValue = inputField.text;
		PlayerPrefs.SetString("SaveText", inputValue);
		Debug.Log("Value Saved!!!!");
	}

    //保存内容を表示ボタンを押した時に呼ばれる関数
	public void FetchButton()
	{
		string fetchedText = PlayerPrefs.GetString("SaveText");
		savedText.text = fetchedText;
	}
}
