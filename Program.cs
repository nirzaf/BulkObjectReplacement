// See https://aka.ms/new-console-template for more information

var factory = new TrackingThemeFactory();
var theme = factory.CreateTheme(true);
var theme2 = factory.CreateTheme(false);
Console.WriteLine(factory.Info);
// Dark theme
// Light theme
      
      
// replacement
var factory2 = new ReplaceableThemeFactory();
var magicTheme = factory2.CreateTheme(true);
Console.WriteLine(magicTheme.Value.BgrColor); // dark gray
factory2.ReplaceTheme(false);
Console.WriteLine(magicTheme.Value.BgrColor); // white