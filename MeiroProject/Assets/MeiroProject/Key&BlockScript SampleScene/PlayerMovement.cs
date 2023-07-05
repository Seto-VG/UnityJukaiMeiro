using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private bool isBlockDestroyed = false; // �u���b�N���j�󂳂�Ă��邩�ǂ����̃t���O

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY) * speed * Time.deltaTime;

        if (!isBlockDestroyed)
        {
            // �v���C���[�̌��݈ʒu����ړ�����v�Z
            Vector2 newPosition = rb.position + movement;

            // �ړ���Ƀu���b�N�����݂���ꍇ�A�ړ������𐧌�����
            Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, 0.5f);
            foreach (Collider2D collider in colliders)
            {
                if (collider.CompareTag("Block"))
                {
                    // �u���b�N�Ƃ̑��΃x�N�g�����v�Z���A�ړ������ɐ�����������
                    Vector2 blockPosition = collider.transform.position;
                    Vector2 blockToPlayer = rb.position - blockPosition;
                    Vector2 blockToNewPosition = newPosition - blockPosition;

                    // �v���C���[���u���b�N�̓����ɓ���Ȃ��悤�ɐ���
                    if (Vector2.Dot(blockToPlayer, blockToNewPosition) > 0f)
                    {
                        // �t�����ւ̈ړ��𐧌�
                        movement = Vector2.ClampMagnitude(blockToPlayer, movement.magnitude);
                    }
                }
            }
        }

        // �v���C���[�̈ړ�
        rb.MovePosition(rb.position + movement);
    }

    public void SetBlockDestroyed(bool value)
    {
        isBlockDestroyed = value;
    }
}