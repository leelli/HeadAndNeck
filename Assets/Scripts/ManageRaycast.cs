using UnityEngine;

public class ManageRaycast : MonoBehaviour
{
    private GameObject obj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 1000.0f, Color.blue);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 300f))
        {
            Debug.Log ("RayCast on " + hit.collider.gameObject.transform.name);
            obj = hit.collider.gameObject;

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log ("Clicked on " + obj.transform.name);
                //obj.transform.GetComponent<Outline>().enabled = true;
                
            }

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log ("Clicked on " + obj.transform.name);
                //obj.transform.GetComponent<Outline>().enabled = false;
            }
        }
        else
        {
            if (obj != null)
            {
                obj = null;
            }
        }
    }
}
