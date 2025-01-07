using SFML.Graphics;
using SFML.Window;

public sealed class Datas{
    private static Datas? instance;
    public static RenderWindow? window;
    public static Font vt323 = new Font("VT323-Regular.ttf");
    public static int? pentagonPreviousPoint = null;
    public static int?[] starPentagonPreviousPoint = new int?[2];

    private Datas(){
        starPentagonPreviousPoint = [null, null];
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