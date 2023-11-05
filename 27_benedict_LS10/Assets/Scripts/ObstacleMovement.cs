using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed * Time.deltaTime, 0, 0f));
        if (transform.position.x < -10)
        {
            GameManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.hit = true;
            Destroy(this.gameObject);
        }
    }
}
