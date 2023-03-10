namespace MongoDB.Types
{
  public sealed class Symbol
  {
    private readonly string _symbol;
    public Symbol(string symbol)
    {
      _symbol = symbol;
    }

    public override string ToString()
    {
      return _symbol;
    }
  }
}
