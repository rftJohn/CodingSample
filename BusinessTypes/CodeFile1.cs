public class Point
{
    
    public int _x;
    public int _y;
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
}


public class UpperTriangle
{
    Point[] vertices = null; 


    public UpperTriangle(int row, int col)
    {
        vertices = new Point[3];
        vertices[0] = new Point(row * 10, col * 10);
        vertices[1] = new Point(row * 10, (col + 1) * 10);
        
    }
    public void Draw()
    {
        
    }
}



public class LowerTriangle
{
    Point[] vertices = null;


    public LowerTriangle(int row, int col)
    {
        vertices = new Point[3]; 
        vertices[0] = new Point(row * 10, col * 10);
        vertices[1] = new Point(row * 10, (col + 1) * 10);

    }
    public void Draw()
    {

    }

}





