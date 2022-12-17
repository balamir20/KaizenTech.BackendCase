using System.Text;
using System.Text.Json;

namespace QuestionThree.JsonParser
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            using StreamReader r = new("response.json");
            string json = r.ReadToEnd();
            var jsonResultList = JsonSerializer.Deserialize<List<Root>>(json);
            var queue = 0;
            int lineNumber = 1;
            StringBuilder stringBuilder = new();
            jsonResultList.ForEach(m =>
            {
                if (m.locale == null)
                {
                    var x = m.boundingPoly.vertices.OrderBy(m => m.x).FirstOrDefault().x;
                    if (queue != 0)
                    {
                        if (queue < x)
                        {
                            stringBuilder.Append(string.Concat(m.description, ' '));
                        }
                        else if (queue >= x)
                        {
                            stringBuilder.Append(string.Concat("\n", string.Format("{0,5}", lineNumber), " | ", m.description, ' '));
                            lineNumber++;
                        }
                    }
                    else
                    {
                        stringBuilder.Append(string.Concat(string.Format("{0,5}", lineNumber), " | ", m.description, "\n"));
                        lineNumber++;
                        stringBuilder.Append(string.Concat(string.Format("{0,5}", lineNumber), " | "));
                        lineNumber++;
                    }
                    queue = x;
                }
            });
            string fileName = "expectedOutput.txt";
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullPath = string.Concat(filePath, "\\", fileName);
            var expectedOutput = new List<string>
            {
                stringBuilder.ToString()
            };
            File.WriteAllLines(fullPath, expectedOutput);
            Console.WriteLine("Check expectedOutput.txt file in your desktop");
        }
    }

    #region Classes
    public class BoundingPoly
    {
        public List<Vertex> vertices { get; set; }
    }
    public class Root
    {
        public string locale { get; set; }
        public string description { get; set; }
        public BoundingPoly boundingPoly { get; set; }
    }
    public class Vertex
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    #endregion
}