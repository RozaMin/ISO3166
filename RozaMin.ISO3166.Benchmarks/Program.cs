using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace RozaMin.ISO3166.Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkMethods>();
        }
    }

    [MemoryDiagnoser]
    [ExceptionDiagnoser]
    [ThreadingDiagnoser]
    public class BenchmarkMethods
    {
        private Consumer _consumer = new Consumer();

        private void Consume(object obj)
        {

        }

        [Benchmark]
        public void Country_All()
        {
            Country.All.Consume(_consumer);
            Consume(Country.All);
        }
        [Benchmark]
        public void Country_Afghanistan()
        {
            var result = Country.Afghanistan.Name;
            Consume(result);
        }
        [Benchmark]
        public void Country_Zimbabwe()
        {
            var result = Country.Zimbabwe.Name;
            Consume(result);
        }
        [Benchmark]
        public void Country_Iran()
        {
            var result = Country.Iran.Name;
            Consume(result);
        }
    }
}