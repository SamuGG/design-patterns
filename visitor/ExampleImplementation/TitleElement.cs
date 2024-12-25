namespace DesignPatterns.Visitor.ExampleImplementation;

public class TitleElement(string text) : IDocumentElement
{
    public string Text => text;

    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
