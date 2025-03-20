using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private LayerMask _groundLayer;
    private Rigidbody _rb;
    private bool isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.5f, _groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }
}
