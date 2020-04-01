using UnityEngine;

namespace DefaultNamespace
{
    [UnityEngine.CreateAssetMenu(fileName = "anyState", menuName = "State", order = 0)]
    public class State : UnityEngine.ScriptableObject
    {
        [TextArea(14,10)][SerializeField] private string storyText;
    }
}