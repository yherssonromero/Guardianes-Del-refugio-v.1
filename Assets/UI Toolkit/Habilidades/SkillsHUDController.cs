using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class SkillsHUDController : MonoBehaviour
{
    private UIDocument document;

    private Button skill1;
    private Button skill2;
    private Button skill3;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        skill1 = root.Q<Button>("skill-1");
        skill2 = root.Q<Button>("skill-2");
        skill3 = root.Q<Button>("skill-3");

        skill1.clicked += () => UseSkill(1);
        skill2.clicked += () => UseSkill(2);
        skill3.clicked += () => UseSkill(3);
    }

    private void UseSkill(int index)
    {
        Debug.Log($"Habilidad {index} usada");
        // Aquí después vamos a llamar al sistema real de habilidades
        // (daño, efectos, cooldown, etc.)
    }
}