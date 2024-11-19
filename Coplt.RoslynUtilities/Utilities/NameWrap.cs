namespace Coplt.Analyzers.Utilities;

public readonly partial record struct NameWrap(string Code)
{
    public override string ToString() => Code;
}
