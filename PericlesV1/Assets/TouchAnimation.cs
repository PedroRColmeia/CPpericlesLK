using UnityEngine;

public class TouchAnimation: MonoBehaviour
{
    public Animator animator;
    public AudioSource musica;

    private bool canInteract = false;

    void Update()
    {
        CheckTouch();
    }


    public void EnableInteraction()
    {
        canInteract = true;
    }

    public void DisableInteraction()
    {
        canInteract = false;
    }

    void CheckTouch()
    {
        if (!canInteract)
            return;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                PlayAnimation();
               
                if (musica.isPlaying)
                {
                    musica.Stop();
                }
                else
                {
                    musica.Play();
                }
            }
        }
    }

    void PlayAnimation()
    {
        animator.Play("Touch");
    }
}
