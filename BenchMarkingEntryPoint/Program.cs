// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Benchmarking;

Console.WriteLine("Benchmark start !");
// run bechmark and produce metrics
BenchmarkRunner.Run<Benchmarks>();
Console.WriteLine("Benchmark end !");
