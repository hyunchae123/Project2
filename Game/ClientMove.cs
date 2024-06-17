using UnityEngine;
using UnityEngine.AI;

public class ClientMove : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;

    [SerializeField] Status Player;
    [SerializeField] Transform destination;
    [SerializeField] float clientX;
    [SerializeField] float clientY;
    [SerializeField] float clientZ;
    [SerializeField] float angle;

    [SerializeField] float foodX;
    [SerializeField] float foodY;

    [SerializeField] SpriteRenderer speechbubble;
    [SerializeField] SpriteRenderer food;

    [SerializeField] bool isFlip;

    Vector3 firstTran;

    [SerializeField] float time;
    [SerializeField] int chairNum;

    int exp;

    void Start()
    {
        firstTran = transform.position;

        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.SetDestination(destination.position);

        speechbubble.enabled = false;
        food.enabled = false;

    }

    void Update()
    {
        Sitting();

        Leave();

        if (transform.position.x == firstTran.x)
        {
            speechbubble.enabled = false;
            food.enabled = false;
            agent.enabled = true;
            agent.SetDestination(destination.position);
        }

    }

    void Sitting()
    {
        if (transform.position.x == destination.position.x && transform.position.z == destination.position.z)
        {

            agent.enabled = false;
            transform.position = new Vector3(clientX, clientY, clientZ);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            GameManager.Instance.inChair(chairNum);

            food thisfood = foodManager.Instance.FoodGacha();
            food.sprite = thisfood.icon;
            exp = thisfood.Score;

            anim.SetBool("arrive", true);
            anim.SetBool("walking", false);

            speechbubble.enabled = true;
            food.enabled = true;

            speechbubble.transform.position = transform.position + new Vector3(foodX, foodY, 0.0f);
            speechbubble.transform.rotation = Quaternion.Euler(33f, 0f, 0f);
            food.transform.rotation = Quaternion.Euler(33f, 0f, 0f);

            if (isFlip == true)
            {
                speechbubble.flipX = true;
                food.flipX = true;
            }

        }
    }

    void Leave()
    {
        if (transform.position.x == clientX && speechbubble.enabled == false)
        {
            Player.GetExp(exp);
            transform.position = firstTran;
            GameManager.Instance.outChair(chairNum);
            anim.SetBool("walking", true);
            anim.SetBool("arrive", false);
        }
    }
}
