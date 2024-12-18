﻿#if !NET5_0_OR_GREATER

using System.Collections;
using System.Runtime.CompilerServices;

namespace DeepCopyExt;

public class ReferenceEqualityComparer : IEqualityComparer<object?>, IEqualityComparer
{
    private ReferenceEqualityComparer() { }
    
    public static ReferenceEqualityComparer Instance { get; } = new();

    public new bool Equals(object? x, object? y) => ReferenceEquals(x, y);

    public int GetHashCode(object? obj)
    {
        return RuntimeHelpers.GetHashCode(obj!);
    }
}

#endif