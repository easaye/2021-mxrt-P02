using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrawing : MonoBehaviour
{
    public GameObject[] shapes;

    private int timer;

    public static RandomDrawing instance = null;
    // Start is called before the first frame update
    void Start()
    {
        displayDrawing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }

    public void displayDrawing()
    {
        shapes[Random.Range(0, shapes.Length)].SetActive(true);
    }
}
