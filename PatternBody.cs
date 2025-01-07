using SFML.Graphics;
using SFML.System;

class Body{
    static Patterns patterns = new Patterns();

    public static RectangleShape[] PatternBodyLines(Application.PatternStates state){
        switch(state){
            case Application.PatternStates.TRIANGLE:
                return LineMaker(patterns.TriangleVertices);
            case Application.PatternStates.DODECAGON:
                return LineMaker(patterns.Dodecagon);
            case Application.PatternStates.HEXAGON:
                return LineMaker(patterns.HexagonVertices);
            case Application.PatternStates.CARPET:
                return LineMaker(patterns.squareBodyPoints);
            case Application.PatternStates.PENTAGON:
                return LineMaker(patterns.PentagonVertices);
            case Application.PatternStates.STAR:
                return LineMaker(patterns.PentagonVertices);
            default:
                return[];
        }
    }

    private static RectangleShape[] LineMaker(Vector2f[] vertices){
        List<RectangleShape> lines = new List<RectangleShape>();
        for (int i = 0; i < vertices.Length; i++)
        {
            Line line;
            if(i != vertices.Length - 1){
                line = new Line(vertices[i], vertices[i+1]);
            }else{
                line = new Line(vertices[i], vertices[0]);
            }
            lines.Add(line);
        }
        return lines.ToArray();
    }
}