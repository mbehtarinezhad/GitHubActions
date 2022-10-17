namespace GitHubActions
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        void Test()
        {
            var a = new Test("asd");
        }
    }

    public class Test
    {
        public Test(string a)
        {

        }
    }
}