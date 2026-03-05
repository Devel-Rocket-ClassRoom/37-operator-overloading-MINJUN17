using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

struct Vector3
{
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static Vector3 operator +(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }
    public static Vector3 operator *(Vector3 v1, float f)
    {
        return new Vector3(v1.X * f, v1.Y * f, v1.Z * f);
    }
    public static Vector3 operator *(float f, Vector3 v1)
    {
        return v1 * f;
    }
    public static Vector3 operator -(Vector3 v)
    {
        return new Vector3(-v.X,  -v.Y, -v.Z);
    }
    public static bool operator ==(Vector3 a, Vector3 b)
    {
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }
    public static bool operator !=(Vector3 a, Vector3 b)
    {
        return !(a == b);
    }
    public override bool Equals(object obj)
    {
        if (obj is Vector3 other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}
