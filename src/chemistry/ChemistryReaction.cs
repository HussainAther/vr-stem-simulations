using UnityEngine;

public class ChemistryReaction : MonoBehaviour
{
    public GameObject acidBeaker;            // The acid-containing beaker
    public GameObject baseBeaker;            // The base-containing beaker
    public GameObject reactionContainer;     // The container where the reaction takes place
    public ParticleSystem reactionBubbles;   // Particle system to simulate bubbles
    public Material reactionMaterial;        // Material to change color during the reaction

    private bool reactionStarted = false;    // Track if reaction has started
    private Color originalColor;             // Store the original color of the material

    void Start()
    {
        // Save the original color of the reaction container
        originalColor = reactionMaterial.color;

        // Deactivate the bubbles initially
        reactionBubbles.Stop();
    }

    void Update()
    {
        // Detect if the acid and base beakers are close enough to trigger the reaction
        if (!reactionStarted && CheckProximity(acidBeaker, baseBeaker))
        {
            StartReaction();
        }
    }

    private bool CheckProximity(GameObject obj1, GameObject obj2)
    {
        // Check if two objects are within a certain distance to start the reaction
        float distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        return distance < 0.5f; // Adjust the threshold as needed
    }

    private void StartReaction()
    {
        reactionStarted = true;
        
        // Change the color of the reaction container to represent a chemical change
        StartCoroutine(ChangeColorOverTime(Color.green, 2.0f));

        // Play the particle system to simulate bubbles
        reactionBubbles.Play();

        // Display a message in the console for debugging
        Debug.Log("Reaction Started: Acid and Base have mixed!");
    }

    private System.Collections.IEnumerator ChangeColorOverTime(Color targetColor, float duration)
    {
        // Gradually change the color of the reaction container
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            reactionMaterial.color = Color.Lerp(originalColor, targetColor, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        reactionMaterial.color = targetColor;
    }

    public void ResetReaction()
    {
        // Reset the reaction state and revert to original settings
        reactionStarted = false;
        reactionMaterial.color = originalColor;
        reactionBubbles.Stop();
    }
}

