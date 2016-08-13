using UnityEngine;
using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Commands;

public class PlayerScript : MonoBehaviour {
    private Rigidbody2D myRigidbody2D;
    private KeyboardController keyboardController;

	// Use this for initialization
	void Start () {
        this.myRigidbody2D = GetComponent<Rigidbody2D>();
        this.keyboardController = new KeyboardController();
        AssignControls();
	}
	
	// Update is called once per frame
	void Update () {
        this.keyboardController.Update();
	}

    // Physics update
    void FixedUpdate()
    {
        
        
    }

    private void AssignControls()
    {
        ICommand jumpCommand = new JumpCommand(this.myRigidbody2D, 23);
        this.keyboardController.RegisterKeyDown(KeyCode.Space, jumpCommand);

        ICommand walkLeftCommand = new WalkCommand(this.myRigidbody2D, new Vector2(-1, 0), 5);
        this.keyboardController.RegisterKey(KeyCode.LeftArrow, walkLeftCommand);

        ICommand walkRightCommand = new WalkCommand(this.myRigidbody2D, new Vector2(1, 0), 5);
        this.keyboardController.RegisterKey(KeyCode.RightArrow, walkRightCommand);

        ICommand stopWalkingCommand = new StopWalkingCommand(this.myRigidbody2D);
        this.keyboardController.RegisterKeyUp(KeyCode.LeftArrow, stopWalkingCommand);
        this.keyboardController.RegisterKeyUp(KeyCode.RightArrow, stopWalkingCommand);
    }
}
