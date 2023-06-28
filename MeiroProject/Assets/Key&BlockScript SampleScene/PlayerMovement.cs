using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private bool isBlockDestroyed = false; // ブロックが破壊されているかどうかのフラグ

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
            // プレイヤーの現在位置から移動先を計算
            Vector2 newPosition = rb.position + movement;

            // 移動先にブロックが存在する場合、移動方向を制限する
            Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, 0.5f);
            foreach (Collider2D collider in colliders)
            {
                if (collider.CompareTag("Block"))
                {
                    // ブロックとの相対ベクトルを計算し、移動方向に制限をかける
                    Vector2 blockPosition = collider.transform.position;
                    Vector2 blockToPlayer = rb.position - blockPosition;
                    Vector2 blockToNewPosition = newPosition - blockPosition;

                    // プレイヤーがブロックの内側に入らないように制限
                    if (Vector2.Dot(blockToPlayer, blockToNewPosition) > 0f)
                    {
                        // 逆方向への移動を制限
                        movement = Vector2.ClampMagnitude(blockToPlayer, movement.magnitude);
                    }
                }
            }
        }

        // プレイヤーの移動
        rb.MovePosition(rb.position + movement);
    }

    public void SetBlockDestroyed(bool value)
    {
        isBlockDestroyed = value;
    }
}