using UnityEngine;

namespace ECM2.Examples.FirstPerson
{
    /// <summary>
    /// First person character input.
    /// </summary>
    
    public class FirstPersonCharacterInput : MonoBehaviour
    {
        private Character _character;

        private SprintAbility _sprintAbility;

        private void Awake()
        {
            // Cache controlled character

            _character = GetComponent<Character>();

            // Cache character sprint ability component

            _sprintAbility = GetComponent<SprintAbility>();
        }

        private void Update()
        {
            // Movement input, relative to character's view direction
            
            Vector2 inputMove = new Vector2()
            {
                x = Input.GetAxisRaw("Mouse X"),
                y = Input.GetAxisRaw("Mouse Y")
            };
            
            Vector3 movementDirection =  Vector3.zero;
            
            movementDirection += _character.GetRightVector() * inputMove.x;
            movementDirection += _character.GetForwardVector() * inputMove.y;

            _character.SetMovementDirection(movementDirection);
            
            // Crouch input
            
            if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.C))
                _character.Crouch();
            else if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.C))
                _character.UnCrouch();
            
            // Jump input
            
            if (Input.GetButtonDown("Jump"))
                _character.Jump();
            else if (Input.GetButtonUp("Jump"))
                _character.StopJumping();

            // Sprint input
            
            if (Input.GetButtonDown("Sprint"))
                _sprintAbility.Sprint();
            else if (Input.GetButtonUp("Sprint"))
                _sprintAbility.StopSprinting();
        }
    }
}
