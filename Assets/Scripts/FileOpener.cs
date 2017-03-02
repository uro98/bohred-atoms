using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FileOpener : MonoBehaviour {

    public Text licenseText;
    public GameObject Panel;
    public GameObject License;

    private TextAsset audiowide;
    private TextAsset russoOne;

    // Use this for initialization
    void Start () {
        License.SetActive(false);
        Panel.SetActive(true);

        audiowide = (TextAsset)Resources.Load("AudiowideOFL");
        russoOne = (TextAsset)Resources.Load("RussoOneOFL");
    }

    public void OpenAudiowide()
    {
        Panel.SetActive(false);
        License.SetActive(true);

        licenseText.text = audiowide.text;
    }

    public void OpenRussoOne()
    {
        Panel.SetActive(false);
        License.SetActive(true);

        licenseText.text = russoOne.text;
    }
}
