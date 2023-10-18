namespace docgenerator
{
    public class Generator : IGenerator
    {
        public bool GenerateDocument(string input, string output)
        {
            bool result = false;

            try
            {
                System.IO.File.Copy(input, output);
                result = true;
            }
            catch (System.Exception)
            {
                //intentionally left blank
            }

            return result;
        }
    }
}
