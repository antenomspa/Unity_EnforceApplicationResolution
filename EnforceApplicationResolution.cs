using UnityEngine;

namespace DDREAMS.FOUNDATION
{
    /// <summary>
    /// Enforces a fixed application window resolution at startup, overriding any previously cached display preferences.
    /// </summary>
    public class EnforceApplicationResolution : MonoBehaviour
    {
        [Header("Window Settings")]
        [SerializeField]
        [Tooltip("The horizontal resolution of the application window, in pixels.")]
        private int _windowWidth = 1920;

        [SerializeField]
        [Tooltip("The vertical resolution of the application window, in pixels.")]
        private int _windowHeight = 1080;

        // --------------------------------------------------------------------------------------------------------------------

        private void Awake()
        {
            Screen.SetResolution(_windowWidth, _windowHeight, FullScreenMode.Windowed);
        }
    }
}
