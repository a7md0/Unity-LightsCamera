using UnityEngine;

using UnityEngine.UI;

public class LightParty : MonoBehaviour
{
    public GameObject spotLightObject;
    private Light spotLight;
    private Range<float> spotLightRange = new Range<float>(0f, 4f);
    public float spotLightIncrement = 2f;


    public GameObject pointLightObject;
    private Light pointLight;
    private Range<float> pointLightRange = new Range<float>(0f, 5f);
    public float pointLightIncrement = 1f;

    public Text uiHeader;

    private void Start() {
        spotLight = spotLightObject.GetComponent<Light>(); // Get light component out from the game object
        spotLight.intensity = 0f; // reset intensity to 0

        pointLight = pointLightObject.GetComponent<Light>(); // Get light component out from the game object
        pointLight.intensity = 0f; // reset intensity to 0
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) { // Press Q
            spotLight.intensity = incrementValue(spotLight.intensity, spotLightRange, spotLightIncrement); // Change intensity
            //print($"spotLight.intensity {spotLight.intensity}");
        }

        if (Input.GetKeyDown(KeyCode.E)) { // Press E
            pointLight.intensity = incrementValue(pointLight.intensity, pointLightRange, pointLightIncrement); // Change intensity
            //print($"pointLight.intensity {pointLight.intensity}");
        }

        uiHeader.text = $"spotLight intensity = {spotLight.intensity}, pointLight.intensity = {pointLight.intensity}";
    }

    float incrementValue(float value, Range<float> range, float increment = 1f) {
        if (value + increment > range.end) {
            return range.start;
        }

        return value + increment;
    }
}

public class Range<T> { // Simple generic range class
    public T start;
    public T end;

    public Range(T start, T end) {
        this.start = start;
        this.end = end;
    }
}
