
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public PlayerMovement player;
    public LevelGenerator generator;
    public float speedIncreaseRate = 0.05f;
    public float minOffset = 8f;

    void Update()
    {
        player.forwardSpeed += speedIncreaseRate * Time.deltaTime;

        if (generator.levelOffset > minOffset)
            generator.levelOffset -= 0.01f * Time.deltaTime;
    }
}
