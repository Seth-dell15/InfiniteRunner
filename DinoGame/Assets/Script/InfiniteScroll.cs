using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.1f; // Vitesse spécifique à cette couche

    private MeshRenderer meshRenderer;
    private Vector2 offset;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // On incrémente l'offset petit à petit
        offset.x += scrollSpeed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = offset;
    }
}