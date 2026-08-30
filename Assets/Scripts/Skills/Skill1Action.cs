using UnityEngine;

public class Skill1Action : MonoBehaviour, ISkillAction
{
    [Header("Animación")]
    [SerializeField] private Animator animator;
    [SerializeField] private string animatorTriggerName = "Skill1";

    [Header("Bloqueo de movimiento mientras dura la animación")]
    [SerializeField] private KobuAttack kobuAttack;

    [Header("Partícula propia de la habilidad 1")]
    [SerializeField] private GameObject particulaSkill1;
    [SerializeField] private Transform puntoSkill1;

    public void Execute()
    {
        Debug.Log("Habilidad 1 ejecutada");
        PlayAnimation();

        // Acá podés sumar más adelante: daño, sonido, etc.
    }

    private void PlayAnimation()
    {
        if (animator == null)
        {
            Debug.LogWarning("Skill1Action: falta asignar el Animator en el Inspector.");
            return;
        }

        animator.SetTrigger(animatorTriggerName);

        // Bloqueamos el movimiento reutilizando la misma bandera que usan los golpes.
        // Se resetea sola con el Animation Event "DejaDeGolpear" al final del clip Mma Kick.
        if (kobuAttack != null)
        {
            kobuAttack.estoyAtacando = true;
        }
        else
        {
            Debug.LogWarning("Skill1Action: falta asignar KobuAttack en el Inspector (no se bloqueará el movimiento).");
        }
    }

    // Animation Event: llamar en el frame exacto donde está activo el hitbox de la skill.
    public void InstanciarParticulaSkill1()
    {
        if (particulaSkill1 != null && puntoSkill1 != null)
        {
            Instantiate(particulaSkill1, puntoSkill1.position, puntoSkill1.rotation);
        }
        else
        {
            Debug.LogWarning("Skill1Action: falta asignar Particula Skill1 o Punto Skill1 en el Inspector.");
        }
    }
}