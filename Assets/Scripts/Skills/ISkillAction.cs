// Interfaz que debe implementar cada script de habilidad individual
// (Skill1Action, Skill2Action, Skill3Action, etc.)
public interface ISkillAction
{
    // Se llama cuando el jugador activa la habilidad (tecla presionada y sin cooldown).
    void Execute();
}