using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{   
    #region SerializeFields
    bool turnedLeft = false;
    bool turnedLeft2 = false;

    [SerializeField]
    PlayerInput input;

    public float dPadValue { get => input.Player.Movement.ReadValue<Vector2>().x; }

    [SerializeField]
    float speed;

    [SerializeField]
    float dashForce;

    [SerializeField]
    GameObject player;

    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    Vector2 moveInput;

    [SerializeField]
    Animator animator;
    #endregion SerializeFields


    private void Awake()
    {
        // Steuert die Inputs
        input = new PlayerInput();
        input.Player.Movement.performed += context => OnMovement(context.ReadValue<Vector2>());
        input.Player.ltTrigger.performed += context => OnLtTrigger();
        input.Player.rtTrigger.performed += context => OnRtTrigger();
        input.Player.xButton.performed += context => OnXButton();
        input.Player.bButton.performed += context => OnBButton();
    }

    // Movement Animation Toggle
    private void OnMovement(Vector2 _input)
    {
        animator.SetBool("Moving", true);
        Debug.Log($"Moving {_input}");
    }

    // Attack Animation Toggle
    private void OnXButton()
    {
        StartCoroutine(AttackFreeze());
        animator.SetTrigger("XButton");
        Debug.Log("Attacking");
    }

    // Block Animation Toggle
    private void OnBButton()
    {
        StartCoroutine(BlockFreeze());
        animator.SetTrigger("BButton");
        Debug.Log("Defending");
    }

    // Linker Dash Toggle
    private void OnLtTrigger()
    {
        Debug.Log("Dashing");
        LtDodge();
    }

    // Rechter Dash Toggle
    private void OnRtTrigger()
    {
        Debug.Log("Dashing");
        RtDodge();
    }

    // Enable nötig um die Input Actions zu aktivieren
    private void OnEnable()
    {
        input.Enable();
    }

    // Blockiert die Bewegung während dem Attackieren
    private IEnumerator AttackFreeze()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        yield return new WaitForSeconds(0.35f);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Blockiert die Bewegung während dem Blocken
    private IEnumerator BlockFreeze()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        yield return new WaitForSeconds(0.5f);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
   
    void Update()
    {
        // Bewegt den Rigidbody
        moveInput = input.Player.Movement.ReadValue<Vector2>();
        moveInput.y = 0f;
        rb.velocity = moveInput * speed;

        // Deaktiviert run animation
        if (dPadValue == 0f)
        {
            animator.SetBool("Moving", false);
        }

        if (turnedLeft2 == false && dPadValue <= -0.1f)
        {
            turnedLeft2 = true;
            player.transform.Rotate(0f, 180f, 0f);
        }

        // Dreht den Spieler nach Rechts
        if (turnedLeft2 == true && dPadValue >= -0.1f)
        {
            turnedLeft2 = false;
            player.transform.Rotate(0f, 180f, 0f);
        }

        // Toggled die RC Methode
        if (turnedLeft == true)
        {
            StartCoroutine(RC());
        }
    }

    // Dreht den Charakter in die richtige Richtung nach einem Dash
    private IEnumerator RC()
    {
        turnedLeft = false;
        yield return new WaitForSeconds(0.25f);
        player.transform.Rotate(0f, 180f, 0f);
    }

    // Nötig um am die Input Actions zu deaktivieren
    private void OnDisable()
    {
        input.Disable();
    }

    // Linke Dash Methode
    private void LtDodge()
    {
        rb.AddForce(Vector2.left * dashForce);
        animator.SetTrigger("LT+RT");
    }

    // Rechte Dash Methode
    private void RtDodge()
    {
        rb.AddForce(Vector2.right * dashForce);
        animator.SetTrigger("LT+RT");
    }
}
