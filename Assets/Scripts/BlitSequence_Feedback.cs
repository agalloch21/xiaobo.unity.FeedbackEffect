using UnityEngine;

public class BlitSequence_Feedback : MonoBehaviour
{
    public RenderTexture sourceRT;
    public RenderTexture destinationRT;
    public RenderTexture backupRT;
    public Material matFeedback;

    // Update is called once per frame
    void Update()
    {
        // Set Backup Render Texture as LastFrameTexture
        matFeedback.SetTexture("LastFrameTexture", backupRT);

        // Feedback effect.
        // sourceRT: RenderTexture 
        // destinationRT: A temporary destination Render Texture
        Graphics.Blit(sourceRT, destinationRT, matFeedback, 0);

        // Copy temporary destination Render Texture to Backup Render Texture
        Graphics.Blit(destinationRT, backupRT);
    }
}
