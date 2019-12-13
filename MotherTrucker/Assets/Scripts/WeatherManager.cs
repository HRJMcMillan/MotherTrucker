using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    // Cache
    [SerializeField] GameObject rainVFX;
    ParticleSystem rain;

    // Variables
    bool isRaining;
    float timeSinceLastWeatherCheck = Mathf.Infinity;
    [SerializeField] float weatherCheckFrequency = 60f;
    [SerializeField] int chanceOfRain = 1;
    [SerializeField] int rainThreshold = 80;
    [SerializeField] int clearSkyThreshold = 20;

    private void Start()
    {
        rain = rainVFX.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastWeatherCheck += Time.deltaTime;
        if (timeSinceLastWeatherCheck >= weatherCheckFrequency)
        {
            CheckWeather();
            timeSinceLastWeatherCheck = 0f;
        }
    }

    private void CheckWeather()
    {
        int precipitation = Random.Range(0, 101)*chanceOfRain;
        print(precipitation);
        if (precipitation >= rainThreshold && rain.isStopped)
        {
            rain.Play();
            print("start raining");
        }
        else if (precipitation <= clearSkyThreshold && rain.isPlaying)
        {
            rain.Stop();
            print("stop raining");
        }
        else
        {
            print("carry on");
            return;
        }
    }
}
