# EnforceApplicationResolution.cs
When building a Unity project with a fixed window resolution, resizing or maximising the application at runtime can cause Unity to cache that state — meaning your Project Settings resolution gets ignored on the next build.

To prevent this, I created a lightweight MonoBehaviour that enforces the intended resolution on startup by calling Screen.SetResolution in Awake(), overriding any previously saved display preferences.

Simply attach it to an Empty GameObject in your bootstrap scene and you're covered.
