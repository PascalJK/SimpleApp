using SimpleConsole;

var shapes = new List<Shape>();
shapes.Add(new Shape({ Height = 100, Width = 30, Type = ShapeType.Circle});
shapes.Add(new Shape({ Height = 150, Width = 50, Type = ShapeType.Rectangle});

var canvas = new Canvas();
canvas.DrawShapes(shapes);
