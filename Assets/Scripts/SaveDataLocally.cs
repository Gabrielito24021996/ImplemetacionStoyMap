using UnityEngine;
using UnityEngine.UI;

public class SaveDataLocally : MonoBehaviour
{
	public InputField nombre;
	public Text nombreCuadro;

	public void SaveButton()
	{
		PlayerPrefs.SetString("nombre", nombre.text);
		nombreCuadro.text = PlayerPrefs.GetString("nombre");
	}

    private void Start()
    {
		nombreCuadro.text = PlayerPrefs.GetString("nombre") ?? "";
    }

	public void Reset()
    {
		PlayerPrefs.DeleteKey("nombre");
		nombreCuadro.text = "";
    }
}