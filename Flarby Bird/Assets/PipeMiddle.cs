using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public logicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
