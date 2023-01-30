using System.Text;

namespace DesignPatterns.CREATIONAL.Builder
{
    public class Code
    {
        public string ClassName;
        public List<Field> Fields = new List<Field>();
        private const int indentSize = 2;
        public Code() { }   
        public Code(string className) 
        { 
            ClassName = className;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize);

            sb.AppendLine($"public class {ClassName}");
            sb.AppendLine("{");
            
            foreach(var field in Fields)
            {
                sb.AppendLine($"{i}public {field.Type} { field.Name};");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

    }

    public class Field
    {
        public string Type, Name;

        public Field(string name, string type ) 
        { 
            Type = type ?? throw new ArgumentNullException(paramName: nameof(type));
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name)); ;
        }
    }
    public class CodeBuilder
    {
        public readonly string ClassName;
        Code root = new Code();

        public CodeBuilder(string className) 
        { 
            this.ClassName= className;
            root.ClassName = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            var f = new Field(name, type);
            root.Fields.Add(f);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

    }



}
