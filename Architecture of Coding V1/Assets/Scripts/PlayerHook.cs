using System;
using UnityEngine;
using DG.Tweening;

public class PlayerHook : MonoBehaviour
{
      [Header("Line Renderer Settings")]
    public LineRenderer lineRenderer;

    [Header("Hook Settings")]
    public Transform hookOrigin; // Hook'un başlangıç noktası (cube1 gibi)
    public float hookDuration = 1f; // Hook çizgisi animasyon süresi
    public float pullDuration = 0.5f; // Çekme süresi
    public LayerMask hookableLayer; // Hooklanabilir objeler için katman
    public float fixedHookHeight = 1.5f; // Sabit hook yüksekliği

    private Vector3 targetPosition; // Hedef pozisyon
    private IHookable hookableTarget; // Hooklanan objeyi tutacak

    private void Start()
    {
        InitializeLineRenderer();
    }

    private void Update()
    {
        HandleHookInput();
    }

    // Line Renderer başlangıç ayarları
    private void InitializeLineRenderer()
    {
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, hookOrigin.position);
        lineRenderer.SetPosition(1, hookOrigin.position);
    }

    // Hook mekanizmasını başlatan input kontrolü
    private void HandleHookInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TryHook();
        }
    }

    // Raycast ile hedefe hook atmayı dener
    private void TryHook()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Raycast ile hooklanabilir bir objeye isabet ediyor mu kontrol et
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, hookableLayer))
        {
            // Hooklanabilir objeyi al
            hookableTarget = hit.collider.GetComponent<IHookable>();

            if (hookableTarget != null)
            {
                targetPosition = hit.point; // Tıklanan objenin pozisyonunu al
                targetPosition.y = fixedHookHeight; // Yüksekliği sabitle (örneğin 1.5f)
                StartHookAnimation(); // Hook animasyonunu başlat
            }
        }
    }

    // Line Renderer ile hook animasyonunu başlatır
    private void StartHookAnimation()
    {
        ResetLineRendererPositions();

        // DOTween ile LineRenderer hedefe doğru çizilir
        DOTween.To(() => lineRenderer.GetPosition(1),
                x => lineRenderer.SetPosition(1, x),
                targetPosition, hookDuration)
            .OnComplete(PullPlayerToTarget); // Animasyon tamamlanınca çekme işlemi başlar
    }

    // LineRenderer pozisyonlarını sıfırlar
    private void ResetLineRendererPositions()
    {
        lineRenderer.SetPosition(0, hookOrigin.position);
        lineRenderer.SetPosition(1, hookOrigin.position);
    }

    // Hook hedefe ulaştıktan sonra oyuncuyu hedefe çeker
    private void PullPlayerToTarget()
    {
        hookOrigin.DOMove(targetPosition, pullDuration)
            .OnUpdate(() =>
            {
                UpdateLineRendererDuringPull();
            })
            .OnComplete(() =>
            {
                FinalizeHook();
            });
    }

    // Çekme işlemi sırasında Line Renderer'ı günceller
    private void UpdateLineRendererDuringPull()
    {
        lineRenderer.SetPosition(0, hookOrigin.position);
    }

    // Çekme işlemi tamamlandıktan sonra hook işlemi tamamlanır
    private void FinalizeHook()
    {
        lineRenderer.SetPosition(1, hookOrigin.position);

        // Eğer hooklanan obje varsa, OnHooked fonksiyonu tetiklenir
        hookableTarget?.OnHooked(targetPosition);
    }
}