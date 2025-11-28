using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour
{
    public Camera mainCamera;
    public Color[] colors;
    private int index = 0;

    void Start()
    {
        if(mainCamera == null)
            mainCamera = Camera.main;
    }

    public void ChangeBackgroundColor()
    {
        index++;
        if (index >= colors.Length)
            index = 0;

        mainCamera.backgroundColor = colors[index];
    }
}
