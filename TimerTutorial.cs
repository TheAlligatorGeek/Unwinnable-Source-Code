using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTutorial : MonoBehaviour
{
    public GameObject textOne;
    public GameObject firstArrow;
    public GameObject textTwo;
    public GameObject secondArrow;
    public GameObject textThree;
    public GameObject thirdArrow;
    public GameObject inputText;
    public GameObject fourArrow;
    public GameObject playerText;

    [SerializeField] private Rigidbody2D rb;
    private float horizontal;
    private float speed = 8f;
    private float raw = 0f;

    Score healthFunction;
    [SerializeField] GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        healthFunction = manager.GetComponent<Score>();
        StartCoroutine(timer1());
    }
    IEnumerator timer1() 
    {
        yield return new WaitForSeconds(1.0f);
        textOne.SetActive(true);
        firstArrow.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        textTwo.SetActive(true);
        secondArrow.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        textThree.SetActive(true);
        thirdArrow.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        inputText.SetActive(true);
        fourArrow.SetActive(true);
        playerText.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        yield return new WaitForSeconds(1.0f);
        healthFunction.scoreNumber -= 1;
        inputText.SetActive(false);
        fourArrow.SetActive(false);
        playerText.SetActive(false);
        textThree.SetActive(false);
        thirdArrow.SetActive(false);
        textTwo.SetActive(false);
        secondArrow.SetActive(false);
        textOne.SetActive(false);
        firstArrow.SetActive(false);
        raw = 1f;
    }
    void Update()
    {
        horizontal = raw;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
