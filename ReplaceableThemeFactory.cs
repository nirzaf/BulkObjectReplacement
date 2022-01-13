namespace BulkObjectReplacement;

public class ReplaceableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> _themes
        = new();

    private ITheme CreateThemeImpl(bool dark)
    {
        return dark ? new DarkTheme() : new LightTheme();
    }

    public Ref<ITheme> CreateTheme(bool dark)
    {
        var r = new Ref<ITheme>(CreateThemeImpl(dark));
        _themes.Add(new WeakReference<Ref<ITheme>>(r));
        return r;
    }

    public void ReplaceTheme(bool dark)
    {
        foreach (var wr in _themes)
        {
            if (wr.TryGetTarget(out var reference))
            {
                reference.Value = CreateThemeImpl(dark);
            }
        }
    }
}