using UnityEngine;
using Unity.VisualScripting;

public class DeadZones : MonoBehaviour
{
    public LogicScript logic; // Declare the 'logic' variable here
   
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        logic.gameOver();         
    }
}
