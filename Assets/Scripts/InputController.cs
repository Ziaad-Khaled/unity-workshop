using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 changeInPosition = new Vector3();
        changeInPosition.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        changeInPosition.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(changeInPosition);
    }
}
