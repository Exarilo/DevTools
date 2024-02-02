using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DevTools.App.Common
{
    public enum Language
    {
        CSharp,
        HTM_CSS,
        Javascript,
        Python,
        CMD,
        Powershell,
        Bash
    }
    public class SnippetManager
    {
        private static SnippetManager instance;

        string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public static SnippetManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SnippetManager();
                }
                return instance;
            }
        }
        private SnippetManager() { }


        public List<CodeSnippet> GetSnippetItems(Language language)
        {
            var path = Path.Combine(parentDirectory, "App", "Snippets", language.ToString());
            var snippetItems = Task.Run(() => GetAllItems(path)).Result.ToList();
            return snippetItems;
        }

        private List<CodeSnippet> GetAllItems(string path)
        {
            var items = new List<CodeSnippet>();

            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string[] subdirectories = Directory.GetDirectories(path);

                foreach (string file in files)
                {
                    var snippet = new CodeSnippet
                    {
                        Name = Path.GetFileName(file),
                        Path = file
                    };
                    items.Add(snippet);
                }

                foreach (string subdirectory in subdirectories)
                {
                    var snippet = new CodeSnippet
                    {
                        Name = Path.GetFileName(subdirectory),
                        Path = subdirectory
                    };
                    snippet.Children.AddRange(GetAllItems(subdirectory));
                    items.Add(snippet);
                }
            }
            return items;
        }
    }
}
