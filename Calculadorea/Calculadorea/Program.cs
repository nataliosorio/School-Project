//using System;
//using Calculadorea;

//class Program
//{
//    static void Main()
//    {
//        int numero1 = 4;
//        int numero2 = 2;

//        Suma sum = new Suma(numero1, numero2);
//        Resta res = new Resta(numero1, numero2);
//        Division divi = new Division(numero1, numero2);
//        Multiplicacion multi = new Multiplicacion(numero1, numero2);

//        sum.Sumar();
//        res.Restar();
//        divi.Dividir();
//        multi.Multiplicar();
//    }
//}

using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Ingresa la URL del archivo C#:");
        string url = Console.ReadLine();

        try
        {
            using var http = new HttpClient();
            string code = await http.GetStringAsync(url);

            string normalized = code.Replace("\r\n", "\n").Replace('\r', '\n');
            int totalLineas = normalized.Length == 0 ? 0 : normalized.Count(c => c == '\n') + 1;

            var tree = CSharpSyntaxTree.ParseText(code, new CSharpParseOptions(LanguageVersion.Preview));
            var root = tree.GetRoot();

            // Clases
            int clases = root.DescendantNodes().OfType<ClassDeclarationSyntax>().Count();

            // Constructores
            int constructores = root.DescendantNodes().OfType<ConstructorDeclarationSyntax>().Count();

            //  Métodos regulares
            int metodosRegulares = root.DescendantNodes().OfType<MethodDeclarationSyntax>().Count();

            // Variables
            int campos = root.DescendantNodes()
                .OfType<FieldDeclarationSyntax>()
                .Sum(f => f.Declaration?.Variables.Count ?? 0);

            int variablesLocales = root.DescendantNodes()
                .OfType<LocalDeclarationStatementSyntax>()
                .Sum(l => l.Declaration?.Variables.Count ?? 0);

            int parametros = root.DescendantNodes()
                .OfType<ParameterSyntax>()
                .Count();

            int propiedades = root.DescendantNodes()
                .OfType<PropertyDeclarationSyntax>()
                .Count(); 

            int variablesTotales = campos + variablesLocales + parametros;

            //  Comentarios
            int lineasComentadas = 0;
            foreach (var trivia in root.DescendantTrivia(descendIntoTrivia: true))
            {
                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                {
                    lineasComentadas += 1;
                }
                else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                {
                    var t = trivia.ToFullString().Replace("\r\n", "\n").Replace('\r', '\n');
                    int lines = t.Count(c => c == '\n') + 1;
                    lineasComentadas += lines;
                }
                else if (trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) ||
                         trivia.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia))
                {
                    var t = trivia.ToFullString().Replace("\r\n", "\n").Replace('\r', '\n');
                    int lines = t.Count(c => c == '\n') + 1;
                    lineasComentadas += lines;
                }
            }

            //  Reporte
            Console.WriteLine(" Análisis del archivo:");
            Console.WriteLine($"- Líneas totales: {totalLineas}");
            Console.WriteLine($"- Líneas comentadas: {lineasComentadas}");
            Console.WriteLine($"- Clases: {clases}");
            Console.WriteLine($"- Constructores: {constructores}");
            Console.WriteLine($"- Métodos regulares: {metodosRegulares}");
            Console.WriteLine($"- Variables totales: {variablesTotales}");
            Console.WriteLine($"   • Campos: {campos}");
            Console.WriteLine($"   • Variables locales: {variablesLocales}");
            Console.WriteLine($"   • Parámetros: {parametros}");
            Console.WriteLine($"- Propiedades (opcional): {propiedades}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

