// See https://aka.ms/new-console-template for more information
using BechMarkDemo;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<BenchmarkClass>();