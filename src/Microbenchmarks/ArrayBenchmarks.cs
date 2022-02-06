// Copyright (c) Martin Costello, 2022. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

namespace Microbenchmarks;

[EventPipeProfiler(BenchmarkDotNet.Diagnosers.EventPipeProfile.CpuSampling)]
public class ArrayBenchmarks
{
    [Benchmark]
    public string[] Empty() => Array.Empty<string>();
}
