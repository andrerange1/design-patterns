namespace DesignPatterns.SOLID.SingleResponsability
{
    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }
}
