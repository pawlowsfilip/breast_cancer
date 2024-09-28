using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    PrepareHeaderForMatch = args => args.Header.ToLower(),
};

using var streamReader = new StreamReader("/home/dev/datasets/breast_cancer/data.csv");
using var csvReader = new CsvReader(streamReader, config);
var items = csvReader.GetRecords<Probe>();

// foreach (var item in items)
// {
//     Console.WriteLine(item);
// }

record Probe
{
    public int Id { get; set; }
    public string Diagnosis { get; set; }
    public double Radius_mean { get; set; }
    public double Texture_mean { get; set; }
    public double Perimeter_mean { get; set; }
    public double Area_mean { get; set; }
    public double Compactness_mean { get; set; }
    public double Concave_points_mean { get; set; }
    public double Symmetry_mean { get; set; }
    public double Fractal_dimension_mean { get; set; }
    public double Radius_se { get; set; }
    public double Texture_se { get; set; }
    public double Perimeter_se { get; set; }
    public double Area_se { get; set; }
    public double Compactness_se { get; set; }
    public double Concave_points_se { get; set; }
    public double Symmetry_se { get; set; }
    public double Fractal_dimension_se { get; set; }
    public double Radius_worst { get; set; }
    public double Texture_worst { get; set; }
    public double Perimeter_worst { get; set; }
    public double Area_worst { get; set; }
    public double Compactness_worst { get; set; }
    public double Concave_points_worst { get; set; }
    public double Symmetry_worst { get; set; }
    public double Fractal_dimension_worst { get; set; }
}
