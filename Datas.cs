using SFML.Graphics;
using SFML.Window;

public sealed class Datas{
    private static Datas? instance;
    public static RenderWindow? window;
    public static Font vt323 = new Font("VT323-Regular.ttf");

    #region Game Restriction Variables
    public static int? lastPoint = null;
    public static int?[] lastTwoPoints = new int?[2];
    #endregion
    private Datas(){
        lastTwoPoints = [null, null];
    }

    public static Datas Instance{
        get {
            if(instance == null){
                instance = new Datas();
            }
            return instance;
        }
    }
}