using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour
{
    public float speed;
    // ���炩���� Animator �R���|�[�l���g�������Ă����悤�ɂ���
    private Animator _animator;

    // �ŏ��̃t���[���X�V�̑O�ɊJ�n���Ăяo����܂�
    void Start()
    {
        // �I�u�W�F�N�g�ɕR�t���Ă��� Animator ���擾����
        _animator = GetComponent<Animator>();

        // �ŏ��̌��� (��) ��ݒ肷��
        _animator.SetFloat("X", 0);
        _animator.SetFloat("Y", -1);
    }

    /// <summary>��莞�Ԃ��ƂɌĂ΂�郁�\�b�h�ł��B</summary>
    void FixedUpdate()
    {
        // �L�[�{�[�h�̓��͕������擾
        var move = GetMove();

        if (move != Vector2.zero)
        {
            // ���͂���Ă���ꍇ�̓A�j���[�^�[�ɕ�����ݒ�
            _animator.SetFloat("X", move.x);
            _animator.SetFloat("Y", move.y);

            // ���͂��������Ɉړ�
            transform.Translate(move * speed);
        }
    }

    /// <summary>�L�[�{�[�h���͂ɂ��ړ��������擾���܂��B</summary>
    /// <returns>�L�[�{�[�h���͂ɂ��ړ������B</returns>
    private Vector2 GetMove()
    {
        Vector2 move = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            move += new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += new Vector2(1, 0);
        }

        // ���͂����l������ꍇ�͐��K�����ĕԂ�
        return move == Vector2.zero ? move : move.normalized;
    }
}