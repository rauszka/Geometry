namespace Codecool.Geometry.Containers
{
    /// <summary>
    ///     Shape Collection class
    /// </summary>
    public class ShapeCollection
    {
        private List<Shape> _shapes { get; set; }

        public ShapeCollection()
        {
            shapes = new List<Shape>();
            shapes.AddRange(CreateSomeShape());
        }

        public string ShowFormulas()
        {
            var shapeFormulas = _shapes.Select(s => s.ShowFormulas()).ToList();
            string result = string.Empty;

            foreach (var shapeFormula in shapeFormulas)
            {
                result += shapeFormula + Environment.NewLine;
            }
            return result;
        }

        public void AddShape()
        {
            Console.WriteLine("Please choose your shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Equilateral Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Regular Pentagon");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Triangle");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please give a radius number:");
                    string radius = Console.ReadLine();
                    var circle = new Circle(double.Parse(radius));
                    shapes.Add(circle);
                    break;
                case 2:
                    Console.WriteLine("Please give a side length:");
                    string eqSideLength = Console.ReadLine();
                    var equilateralTriangle = new EquilateralTriangle(double.Parse(eqSideLength));
                    shapes.Add(equilateralTriangle);
                    break;
                case 3:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string aSide = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string bSide = Console.ReadLine();
                    var rectangle = new Rectangle(double.Parse(aSide), double.Parse(bSide));
                    shapes.Add(rectangle);
                    break;
                case 4:
                    Console.WriteLine("Please give a side length:");
                    string rpSideLength = Console.ReadLine();
                    var regularPentagon = new RegularPentagon(double.Parse(rpSideLength));
                    shapes.Add(regularPentagon);
                    break;
                case 5:
                    Console.WriteLine("Please give a side length:");
                    string squSideLength = Console.ReadLine();
                    var square = new Square(double.Parse(squSideLength));
                    shapes.Add(square);
                    break;
                case 6:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string triangleA = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string triangleB = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'c': ");
                    string triangleC = Console.ReadLine();
                    var triangle = new Triangle(double.Parse(triangleA), double.Parse(triangleB),
                        double.Parse(triangleC));
                    shapes.Add(triangle);
                    break;
            }
        }

        public string multipleCharacters(char chr, int num)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                result.Append(chr);
            }

            return result.ToString();
        }

        private List<Shape> CreateSomeShape()
        {
            Cricle circle = new Cricle(12);
            EquilateralTriangle egTriangle = new EquilateralTriangle(14);
            Rectangle rectangle = new Rectangle(11);
            RegularPentagon regularPentagon = new RegularPentagon(11);
            Square square = new Square(32);
            Triangle triangle = new Triangle(33);

            return new List<Shape>(){circle, rectangle, egTriangle, regularPentagon, square, triangle}
        }

        public void GetShapesTable()
        {
            int idNum = 3;
            int classNameNum = 20;
            int ToStringNum = 40;
            int perimeterNum = 12;
            int perimeterFormulaNum = 12;
            int areaNum = 12;
            int areaFormulaNum = 30;

            string idHeader = "ID";
            string classHeader = "Class";
            string toStringHeader = "toString";
            string perimeterHeader = "Perimeter";
            string areaHeader = "Area";
            string FormulaHeader = "Formula";

            StringBuilder table = new StringBuilder();

            table.Append("/")
                .Append(multipleCharacters('-', 135))
                .Append("\\\n");

            table.Append("|")
                .Append(multipleCharacters(' ', idNum - idHeader.Length))
                .Append(idHeader)
                .Append("|")
                .Append(multipleCharacters(' ', classNameNum - classHeader.Length))
                .Append(classHeader)
                .Append("|")
                .Append(multipleCharacters(' ', ToStringNum - toStringHeader.Length))
                .Append(toStringHeader)
                .Append("|")
                .Append(multipleCharacters(' ', perimeterNum - perimeterHeader.Length))
                .Append(perimeterHeader)
                .Append("|")
                .Append(multipleCharacters(' ', perimeterFormulaNum - FormulaHeader.Length))
                .Append(FormulaHeader)
                .Append("|")
                .Append(multipleCharacters(' ', areaNum - areaHeader.Length))
                .Append(areaHeader)
                .Append("|")
                .Append(multipleCharacters(' ', areaFormulaNum - FormulaHeader.Length))
                .Append(FormulaHeader)
                .Append("|\n");

            table.Append("|")
                .Append(multipleCharacters('-', idNum))
                .Append("|")
                .Append(multipleCharacters('-', classNameNum))
                .Append("|")
                .Append(multipleCharacters('-', ToStringNum))
                .Append("|")
                .Append(multipleCharacters('-', perimeterNum))
                .Append("|")
                .Append(multipleCharacters('-', perimeterFormulaNum))
                .Append("|")
                .Append(multipleCharacters('-', areaNum))
                .Append("|")
                .Append(multipleCharacters('-', areaFormulaNum))
                .Append("|\n");

            for (int i = 0; i < shapes.Count; i++)
            {
                Shape shape = shapes[i];
                int id = i;
                String className = shape.GetType().Name;
                String areaFormula = shape.AreaFormula;
                String perimeterFormula = shape.PerimeterFormula;
                double perimeter = Math.Round(shapes[i].Perimeter, 2);
                double area = Math.Round(shapes[i].Area, 2);

                table.Append("|")
                    .Append(multipleCharacters(' ', idNum - id.ToString().Length))
                    .Append(id)
                    .Append("|")
                    .Append(multipleCharacters(' ', classNameNum - className.Length))
                    .Append(className)
                    .Append("|")
                    .Append(multipleCharacters(' ', ToStringNum - shape.ToString().Length))
                    .Append(shape)
                    .Append("|")
                    .Append(multipleCharacters(' ', perimeterNum - perimeter.ToString().Length))
                    .Append(perimeter)
                    .Append("|")
                    .Append(multipleCharacters(' ', perimeterFormulaNum - perimeterFormula.Length))
                    .Append(perimeterFormula)
                    .Append("|")
                    .Append(multipleCharacters(' ', areaNum - area.ToString().Length))
                    .Append(area)
                    .Append("|")
                    .Append(multipleCharacters(' ', areaFormulaNum - areaFormula.Length))
                    .Append(areaFormula)
                    .Append("|\n");

                if (i != shapes.Count - 1)
                {
                    table.Append("|")
                        .Append(multipleCharacters('-', idNum))
                        .Append("|")
                        .Append(multipleCharacters('-', classNameNum))
                        .Append("|")
                        .Append(multipleCharacters('-', ToStringNum))
                        .Append("|")
                        .Append(multipleCharacters('-', perimeterNum))
                        .Append("|")
                        .Append(multipleCharacters('-', perimeterFormulaNum))
                        .Append("|")
                        .Append(multipleCharacters('-', areaNum))
                        .Append("|")
                        .Append(multipleCharacters('-', areaFormulaNum))
                        .Append("|\n");
                }
            }

            table.Append("\\")
                .Append(multipleCharacters('-', 135))
                .Append("/\n");

            Console.WriteLine(table.ToString());
        }
    }
}
