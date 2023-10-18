using Microsoft.CodeAnalysis;

namespace docgenerator
{
    public interface IGenerator
    {
        bool GenerateDocument(string input, string output);
    }
}