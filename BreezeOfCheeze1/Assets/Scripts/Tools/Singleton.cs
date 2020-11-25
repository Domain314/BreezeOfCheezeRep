using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static bool applicationIsQuitting = false;

    private static T m_Instance;

    public static T Instance
    {
        get
        {
            if (applicationIsQuitting)
            {
                return null;
            }

            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType<T>();

                if (m_Instance == null)
                {
                    m_Instance = new GameObject(typeof(T).Name).AddComponent<T>();
                }
                // DontDestroyOnLoad(m_Instance.gameObject);
            }
            return m_Instance;
        }
    }

    // fixes the Clean-Up-Problem, when quitting application.
    // see: https://answers.unity.com/questions/1274772/some-objects-were-not-cleaned-up-when-closing-the-4.html
    // Damn Singletons.... still not working!
    [RuntimeInitializeOnLoadMethod]
    static void RunOnStart()
    {
        Application.quitting += () => applicationIsQuitting = true;
    }
}