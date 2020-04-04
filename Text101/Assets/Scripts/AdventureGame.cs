using Text101Namespace;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;
    [SerializeField] private State maxMovesGameOverState;
    [SerializeField] private int movesCountMax;
    
    private State state;
    public int movesCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.StoryText;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (Input.anyKey)
        {
            var nextState = state.NextStates;
            if (nextState.Length > 0 && Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = nextState[0];
                movesCounter++;
            }
            else if (nextState.Length > 1 && Input.GetKeyDown(KeyCode.Alpha2))
            {
                state = nextState[1];
                movesCounter++;
            }
            else if (nextState.Length > 2 && Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = nextState[2];
                movesCounter++;
            }
            else
            {
                Debug.Log("Unmanaged key pressed");
            }

            if (movesCounter >= movesCountMax)
            {
                state = maxMovesGameOverState;
                movesCounter = -1;
            }
            textComponent.text = state.StoryText;
        }
    }
}
