using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectTrigger : MonoBehaviour, IPointerClickHandler
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    private void Start()
    {
        // Ensure there's an AudioSource component attached to this GameObject.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the audio clip to the AudioSource component.
        audioSource.clip = audioClip;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // This method is called when the object is clicked with the mouse or touched.
        // You can add your custom logic here.
        
        if (audioSource != null && audioClip != null)
        {
            // Play the audio clip.
            audioSource.Play();
        }
    }
}
