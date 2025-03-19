using UnityEngine;

public class PianoKey : MonoBehaviour
{
    [SerializeField] private Sprite whiteKey; // Ảnh bình thường
    [SerializeField] private Sprite redKey;   // Ảnh khi nhấn
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource; // Thay vì AudioClip, ta dùng AudioSource

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Lấy ảnh phím
        audioSource = GetComponent<AudioSource>(); // Lấy AudioSource
    }

    void OnMouseDown()
    {
        spriteRenderer.sprite = redKey; // Đổi màu phím đàn
        if (audioSource != null) audioSource.Play(); // Phát âm thanh
    }

    void OnMouseUp()
    {
        spriteRenderer.sprite = whiteKey; // Trở lại màu trắng
    }
}