using UnityEngine;

public class AppMonobehaviour : MonoBehaviour
{
    private UserInput _userInput;

    // Start is called before the first frame update
    void Start()
    {
        _userInput = UserInput.Create();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

internal class UserInput
{
    public static UserInput Create()
    {
        return new UserInput();
    }
}
