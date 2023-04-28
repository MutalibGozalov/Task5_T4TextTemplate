string[] classNames = File.ReadAllLines(@"C:\Users\99450\Desktop\PROJECTS\VStudio\T4_TextTemplateDemo\TextTemplate\Models\Models.txt");
string directory = @"C:\Users\99450\Desktop\PROJECTS\VStudio\T4_TextTemplateDemo\TextTemplate\Models";
foreach (var name in classNames)
{
    string ModelPath = directory + @"\" + name + ".cs";

    string ModelContent = $@"
namespace T4_TextTemplate.Models;
public class {name}
{{


}}
		";

    if (File.Exists(ModelPath))
    {
        File.Delete(ModelPath);
        File.WriteAllText(ModelPath, ModelContent);
    }
    else File.WriteAllText(ModelPath, ModelContent);
}