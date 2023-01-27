
/*
 * Single responsability principle 
 * Cada coisa tem sua responsabilidade única
 * 
 * Nesse exemplo temos a classe Jornal onde podemos inserir ou remover informações de texto. 
 * Ela faz suas proprias coisas internamente. Porém se quisermos persistir essas informações 
 * em um banco ao invés de deixar essa responsabilidade com a própria classe Jornal criamos
 * outra classe responsável somente pela persistencia. Criamos a classe Persistence que é responsavel
 * unica e exclusivamente por pesistir os dados. No nosso caso ela persiste Jornal mas se tivessemos
 * outras classes como Revistas, Livros ou o que fosse bastaria por na classe Persistence deixando
 * a responsabilidade de Persistencia somente para ela.
 */



var j = new Journal();
j.AddEntry("I cried today");
j.AddEntry("I ate a bug");
Console.WriteLine(j);


var p = new Persistence();
var filename = @"C:\design-patterns\journal.txt";
p.SaveToFile(j, filename, true);

public class Persistence
{
    public void SaveToFile(Journal j, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
            File.WriteAllText(filename, j.ToString());
    }
}


public class Journal
{
    private readonly List<string> entries = new List<string>(); 
    private static int count = 0;

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count;
    }

    public void RemoveEntry(int index) 
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}


    
