using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;
public enum AnimatorState
{
    idle, walk, attack
}
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float attackSpeed;
    private Rigidbody2D rb;
    [SerializeField] private GameObject target;
    private Animator animator;
    private bool animState;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Attack();
    }
    void FixedUpdate()
    {
        Movement();
        Attack();
    }
    void Movement()
    {
        float dir = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(dir));
        if (dir != 0)
        {
            transform.localScale = new Vector3(dir, transform.localScale.y, transform.localScale.z);
            rb.MovePosition(transform.position + new Vector3(dir,0,0)*Time.deltaTime*speed);
        }
    }
    void Attack()
    {
        if (Input.GetKey(KeyCode.Space)&&target.gameObject.activeSelf==true)
        {
            animator.SetBool("IsAttacking", true);
            rb.MovePosition(Vector3.MoveTowards(transform.position,target.transform.position,Time.deltaTime*attackSpeed));
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }
}
