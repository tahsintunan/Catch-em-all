using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camAnim;
    private static readonly int ShakeId = Animator.StringToHash("shake");

    public void CamShake()
    {
        camAnim.SetTrigger(ShakeId);
    }
}
