using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : Singleton<SoundManager>
{
    public Sound[] Splashes;
    public Sound[] StomachGrowl;
    public Sound BackgroundMusic;
    public Sound NuclearWarning;
    public Sound NewsAlert;

    private void Awake()
    {
        foreach (Sound s in Splashes)
        {
            CreateAudioSource(s);
        }
        foreach (Sound s in StomachGrowl)
        {
            CreateAudioSource(s);
        }
        CreateAudioSource(BackgroundMusic);
        CreateAudioSource(NuclearWarning);
        CreateAudioSource(NewsAlert);

        EventManager.Instance.EndOfTutorial += PlayMusic;
    }

    void CreateAudioSource(Sound sound)
    {
        sound.source = gameObject.AddComponent<AudioSource>();
        sound.source.clip = sound.clip;
        sound.source.volume = sound.volume;
        sound.source.pitch = sound.pitch;
        sound.source.loop = sound.loop;
    }

    void PlayMusic()
    {
        BackgroundMusic.source.Play();
    }

    public void ChooseSplash()
    {
        int rnd = Random.Range(0, Splashes.Length);
        float frnd = Random.Range(0.7f, 1.5f);
        Splashes[rnd].source.pitch = frnd;
        Splashes[rnd].source.Play();
    }

    public void PlayStomachGrowl()
    {
        int rnd = Random.Range(0, StomachGrowl.Length);
        float frnd = Random.Range(0.7f, 2f);
        StomachGrowl[rnd].source.pitch = frnd;
        StomachGrowl[rnd].source.Play();
    }
}
