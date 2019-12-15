using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    // Cache
    [SerializeField] GameObject rainVFX;
    ParticleSystem rain;
    AudioSource rainSFX;

    // Variables
    bool isRaining = false;
    float timeSinceLastWeatherCheck = Mathf.Infinity;
    [SerializeField] float weatherCheckFrequency = 60f;
    [SerializeField] int chanceOfRain = 1;
    [SerializeField] int rainThreshold = 80;
    [SerializeField] int clearSkyThreshold = 20;

    private void Start()
    {
        rain = rainVFX.GetComponent<ParticleSystem>();
        rainSFX = GetComponent<AudioSource>();
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
        if (precipitation >= rainThreshold && !isRaining)
        {
            isRaining = true;
            rain.Play();
            rainSFX.Play();
        }
        else if (precipitation <= clearSkyThreshold && isRaining)
        {
            isRaining = false;
            rain.Stop();
            rainSFX.Stop();
        }
        else
        {
            // Do nothing
        }
    }
}
