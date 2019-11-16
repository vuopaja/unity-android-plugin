using UnityEngine;

public class AndroidPluginExample : MonoBehaviour
{
	UnityEngine.UI.Text text;
	AndroidJavaClass javaClass;

	void Start ()
	{
		// Get a reference to our Java class
		javaClass = new AndroidJavaClass("com.vuopaja.unityplugintutorial.RandomNumber");

		text = GetComponentInChildren<UnityEngine.UI.Text>();
		var button = GetComponentInChildren<UnityEngine.UI.Button>();
		button.onClick.AddListener(onUiButtonClicked);
	}
	
	void onUiButtonClicked()
	{
		// Call the static method using the java class reference.
		// We call the Generate method that returns an integer and give the maximum range as an argument
		int randomNmb = javaClass.CallStatic<int>("Generate", 100);
		text.text = randomNmb.ToString();
	}
}
