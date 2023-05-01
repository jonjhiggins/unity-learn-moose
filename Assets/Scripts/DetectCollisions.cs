using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameObject slider;
    private UnityEngine.UI.Slider sliderComponent;
    public int numberOfPizzasRequired = 1;
    private int numberOfPizzasEaten = 0;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        sliderComponent = slider.GetComponent<UnityEngine.UI.Slider>();
        sliderComponent.maxValue = numberOfPizzasRequired;
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            HandlePlayerCollision();
        }
        else if (collider.tag == "Pizza")
        {
            HandlePizzaEat();
        }
    }

    void HandlePlayerCollision()
    {
        scoreManager.DecreaseLives();
        Destroy(gameObject);
    }

    void HandlePizzaEat()
    {
        if (numberOfPizzasEaten == numberOfPizzasRequired)
        {
            return;
        }

        numberOfPizzasEaten += 1;
        sliderComponent.value = numberOfPizzasEaten;
        scoreManager.IncreaseScore();

        if (numberOfPizzasEaten == numberOfPizzasRequired)
        {
            StartCoroutine(DestroyGameObject());
        }
    }

    IEnumerator DestroyGameObject()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);

    }
}
