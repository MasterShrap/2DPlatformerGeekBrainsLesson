using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed;
    [SerializeField] private float _duration;
    [SerializeField] private float _jump;
    
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Run();
        Jump();
        Animation();
        Flip();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector3.up * _jump;
        }
    }

    private void Run()
    {
        _duration = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(_speed * _duration * Time.deltaTime, 0, 0);
    }

    private void Animation()
    {
        if (_duration != 0)
            _animator.SetBool("Run", true);
        else
            _animator.SetBool("Run", false);
    }

    private void Flip()
    {
        if (_duration >= 0)
            _spriteRenderer.flipX = false;
        else
            _spriteRenderer.flipX = true;
    }
}
