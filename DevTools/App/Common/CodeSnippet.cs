using System;
using System.Collections.Generic;
using System.IO;

namespace DevTools.App.Common
{
    public class CodeSnippet
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public List<CodeSnippet> Children { get; set; } = new List<CodeSnippet>();
        public CodeSnippet()
        {

        }
        public string GetFileContent()
        {
            if (!string.IsNullOrEmpty(Path) && File.Exists(Path))
            {
                try
                {
                    string fileContent = File.ReadAllText(Path);
                    return fileContent;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error during file parsing : {ex.Message}");
                }
            }
            else
            {
                throw new FileNotFoundException("File or path invalid.");
            }
        }

    }
}
