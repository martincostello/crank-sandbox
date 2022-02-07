// Copyright (c) Martin Costello, 2022. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

namespace Microbenchmarks;

public class EmptyBenchmarks
{
    [Benchmark(Baseline = true)]
    public string[] ArrayEmpty() => Array.Empty<string>();

    [Benchmark]
    public object EnumerableEmpty() => Enumerable.Empty<string>();
}
