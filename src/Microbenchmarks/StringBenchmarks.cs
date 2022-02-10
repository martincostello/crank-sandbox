// Copyright (c) Martin Costello, 2022. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

namespace Microbenchmarks;

public class StringBenchmarks
{
    private static readonly char[] TwentySpaces = Enumerable.Repeat(' ', 20).ToArray();

    [Benchmark(Baseline = true)]
    public string ConstructorArray() => new(TwentySpaces);

    [Benchmark]
    public string ConstructorSpan() => new(TwentySpaces.AsSpan());
}
