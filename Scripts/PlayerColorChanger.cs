using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    public Renderer playerRenderer;
    public Color[] colors;
    private int index = 0;

    void Start()
    {
        if (playerRenderer == null)
            playerRenderer = GetComponent<Renderer>();
    }

    public void ChangePlayerColor()
    {
        index++;
        if (index >= colors.Length)
            index = 0;

        playerRenderer.material.color = colors[index];
    }
}
