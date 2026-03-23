using UnityEngine;

public class IslandBuilder : MonoBehaviour
{
    public Transform leftEdge;
    public Transform middle;
    public Transform rightEdge;

    public void SetSize(float width)
    {
        // 1. On ajuste la largeur du milieu (Sprite Renderer en mode Tiled)
        SpriteRenderer middleSR = middle.GetComponent<SpriteRenderer>();
        middleSR.size = new Vector2(width, middleSR.size.y);

        // 2. On positionne les bords par rapport au centre
        // Le milieu s'étend de -width/2 à +width/2
        float halfWidth = width / 2f;
        leftEdge.localPosition = new Vector3(-halfWidth - 0.5f, 0, 0); // -0.5f car le bord a une largeur de 1
        rightEdge.localPosition = new Vector3(halfWidth + 0.5f, 0, 0);

        // 3. On ajuste le BoxCollider2D pour qu'il couvre toute l'île
        BoxCollider2D col = GetComponent<BoxCollider2D>();
        if (col != null)
        {
            col.size = new Vector2(width + 2f, col.size.y); // +2 pour compter les deux bords
        }
    }
}