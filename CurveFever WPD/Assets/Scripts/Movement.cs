using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;

    float horizontal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //wzor na poruszanie
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        //obrót
        transform.Rotate(Vector3.forward*-horizontal*rotationSpeed*Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //rzuć texboxa do tej formuły !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        if (col.tag == "killer")
        {
            GameManager.FindObjectOfType<GameManager>().TheEndgame();
            speed = 0f;
            rotationSpeed = 0f;
        }
    }
}
