using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid;
    [SerializeField] private float startingSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;

        float xVelocity = -1f;
        float xVelocitylaunch = 1f;

        if (isRight == true)
        {
            xVelocity = xVelocitylaunch;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);

        rigid.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
