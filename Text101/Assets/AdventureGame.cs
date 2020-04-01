using System.Collections;
using System.Collections.Generic;
using Text101Namespace;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;
    
    private State state;
    
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
        var nextState = state.NextStates;
        if (nextState.Length > 0 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if (nextState.Length > 1 && Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }
        else if (nextState.Length > 2 && Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextState[2];
        }
        else
        {
            Debug.Log("Unmanaged key pressed");
        }
        textComponent.text = state.StoryText;
    }
}
