using UnityEngine;
using UnityEngine.UI;

public class ProposalManager : MonoBehaviour
{
    [Header("Target Object")]
    public Renderer targetRenderer;       // The object whose texture changes
    public Texture2D proposedTexture;     // The new texture to apply
    
    private Texture2D originalTexture;   // Store original for undo/reject

    void Start()
    {
        // Cache the original texture
        originalTexture = (Texture2D)targetRenderer.material.mainTexture;
    }

    // Hook this to your "Make Proposal" button's OnClick()
    public void OnProposalButtonClicked()
    {
        ApplyTexture(proposedTexture);
        // Then broadcast to other players (see multiplayer section below)
    }

    void ApplyTexture(Texture2D texture)
    {
        // Clone the material so you don't modify the shared asset
        targetRenderer.material = new Material(targetRenderer.material);
        targetRenderer.material.mainTexture = texture;
    }
}