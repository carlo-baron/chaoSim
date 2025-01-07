using VectorCalculations;
using SFML.System;
using SFML.Graphics;

class PatternsOptionScene : Scene
{
    Button backButton;

    Button triangle;
    Button dodecagon;
    Button hexagon;
    Button carpet;

    ButtonLabel triangleText;
    ButtonLabel circleText;
    ButtonLabel hexagonText;
    ButtonLabel carpetText;

    Vector2f optionSize = new Vector2f(200, 75);
    uint textSize = 36;
    public PatternsOptionScene() : base("Pattern Options")
    {
        Vector2f floatWindowSize = new Vector2f(windowData.Size.X, windowData.Size.Y);

        #region Shapes
        backButton = new Button(new Vector2f(50, 50))
        {
            Origin = new Vector2f(0, 0),
            Position = new Vector2f(windowData.Size.X - 50, 0)
        };
        // options
        triangle = new Button(optionSize)
        {
            Position = new Vector2f(FindCenter.Window().X, FindCenter.Window().Y - 150),
        };
        dodecagon = new Button(optionSize)
        {
            Position = new Vector2f(FindCenter.Window().X, FindCenter.Window().Y - 50),
        };
        hexagon = new Button(optionSize)
        {
            Position = new Vector2f(FindCenter.Window().X, FindCenter.Window().Y + 50),
        };
        carpet = new Button(optionSize)
        {
            Position = new Vector2f(FindCenter.Window().X, FindCenter.Window().Y + 150),
        };

        shapes.Add(triangle);
        shapes.Add(dodecagon);
        shapes.Add(hexagon);
        shapes.Add(carpet);
        shapes.Add(backButton);
        #endregion

        #region Texts
        triangleText = new ButtonLabel("TRIANGLE", textSize, triangle);
        circleText = new ButtonLabel("DODECAGON", textSize, dodecagon);
        hexagonText = new ButtonLabel("HEXAGON", textSize, hexagon);
        carpetText = new ButtonLabel("CARPET", textSize, carpet);

        shapes.Add(triangleText);
        shapes.Add(circleText);
        shapes.Add(hexagonText);
        shapes.Add(carpetText);
        #endregion

        #region Events
        windowData.Closed += (sender, args) => windowData.Close();
        backButton.Click += (sender, args) => BackButton();
        triangle.Click += (sender, args) => RunPattern(Application.PatternStates.TRIANGLE);
        dodecagon.Click += (sender, args) => RunPattern(Application.PatternStates.DODECAGON);
        hexagon.Click += (sender, args) => RunPattern(Application.PatternStates.HEXAGON);
        carpet.Click += (sender, args) => RunPattern(Application.PatternStates.PENTAGON);
        #endregion
    }
    public override void Functions()
    {
        backButton.OnClickBehavior(windowData);
        triangle.OnClickBehavior(windowData);
        dodecagon.OnClickBehavior(windowData);
        hexagon.OnClickBehavior(windowData);
        carpet.OnClickBehavior(windowData);
    }
    void BackButton()
    {
        windowData.Close();
        Menu menu = new Menu();
        Program.MainLoop(menu);
    }

    void RunPattern(Application.PatternStates state)
    {
        windowData.Close();
        Application patternApp = new Application(state);
        Program.MainLoop(patternApp);
    }
}