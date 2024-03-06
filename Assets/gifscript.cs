using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gifscript : MonoBehaviour
{
 

    public Texture2D[] frames; // Array to hold the frames of the GIF
    public float framesPerSecond = 10f; // Frames per second for the animation

    private Renderer rend;
    private int currentFrameIndex = 0;
    private float timer = 0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.mainTexture = frames[0]; // Set the initial frame
    }

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Calculate the time each frame should be displayed
        float frameTime = 1f / framesPerSecond;

        // If the timer exceeds the frame time, switch to the next frame
        if (timer >= frameTime)
        {
            // Increment the current frame index
            currentFrameIndex = (currentFrameIndex + 1) % frames.Length;

            // Update the texture with the new frame
            rend.material.mainTexture = frames[currentFrameIndex];

            // Reset the timer
            timer = 0f;
        }
    }
}


