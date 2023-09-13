using Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace Benchmarking
{
   
    
    [Config(typeof(ConfigBench))]
    public class Benchmarks
    {

        public class ConfigBench : ManualConfig
        {
            public ConfigBench()
            {
                SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Percentage).WithTimeUnit(Perfolizer.Horology.TimeUnit.Millisecond);
            }
        }

        [Params(100, 1000, 10000)]
        public int N;

        public int[]? Values;

        [IterationSetup]
        public void IterationSetup()
        {
            Values = new int[N] ;
            for (int i = 0; i < N; i++)
            {
                Values[i]= Random.Shared.Next(0,100);
            }

        }

        [Benchmark]
        public void BubbleSorting()
        {
            ISortStrategy instance = new MergeSortStrategy();
            instance.Sort(Values);
        }
        [Benchmark]
        public void QuickSorting()
        {
            ISortStrategy instance = new QuickSortStrategy();
            instance.Sort(Values);
        }

        [Benchmark]
        public void MergeSorting()
        {
            ISortStrategy instance = new MergeSortStrategy();
            instance.Sort(Values);
        }
        [Benchmark]
        public void HeapSorting()
        {
            ISortStrategy instance = new HeapSortStrategy();
            instance.Sort(Values);
        }
    }
}