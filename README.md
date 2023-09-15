# Sorting-algos-benchmarking
- Welcome to the Sorting Algorithm Benchmark project! This repository provides a benchmarking for various sorting algorithms in C# languages using [BenchmarkDotnet](https://github.com/dotnet/BenchmarkDotNet) and with a [Strategy](https://refactoring.guru/design-patterns/strategy) Design pattern to implements differents sorting algos. As you must know, Sorting is a fundamental operation in computer science, and it's important to understand how different algorithms perform under various conditions.

## Included Sorting strategies 
  1.  Bubble Sorting
  2.  Heap Sorting
  3.  Merge Sorting
  4.  uickSorting


### Installation

1. Clone this repository:

   ```sh
   $ git clone https://github.com/zwdOr20/Sorting-algos-benchmarking.git
  
2. Move to the solution directory
   ```sh
   $ cd solution
3. restore and build project

     ```sh
   $ dotnet restore
    $ dotnet build
4. Move to the BenchmarkingEntryPoint project directory
    ```sh
    $ cd your-apiTenisAPI.API

5. run api run
    ```sh
    $ dotnet run --property:Configuration=Release
6. Result will be in the directory
  
   - if you are using .NET6 the benchmarking result will be generated in this directory : 
   > \BenchMarkingEntryPoint\bin\Release\net6.0\BenchmarkDotNet.Artifacts\results
