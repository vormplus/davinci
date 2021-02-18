using UnityEngine;
using UnityEngine.UI;
using com.shamsdev.davinci;

public class SimpleExample : MonoBehaviour
{
    public Image image;
    public string imageUrl;

    private void Start()
    {
        //Simple usage - Single line of code and ready to go!
        Davinci.get().load(imageUrl).into(image).start();
    }
}