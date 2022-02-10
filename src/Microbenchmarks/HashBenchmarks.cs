// Copyright (c) Martin Costello, 2022. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

namespace Microbenchmarks;

public class HashBenchmarks
{
    private static readonly byte[] Buffer = RandomNumberGenerator.GetBytes(64);

    [Benchmark(Baseline = true)]
    public byte[] SHA256ComputeHash()
    {
        using var algorithm = SHA256.Create();
        return algorithm.ComputeHash(Buffer);
    }

    [Benchmark]
    public byte[] SHA256HashData()
        => SHA256.HashData(Buffer);
}
