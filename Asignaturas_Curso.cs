// Clase que representa el Nivel de estudio con una lista de materias
public class Curso
{
    public string NombreCurso { get; set; }
    private List<string> materias;

    // Constructor que inicializa el Curso y su lista de materias
    public Curso(string nombreCurso)
    {
        NombreCurso = nombreCurso;
        materias = new List<string>();
    }

    // Método para agregar una asignatura al curso
    public void AgregarAsignatura(string asignatura)
    {
        materias.Add(asignatura);
    }

    // Método para mostrar todas las materias del curso
    public void Mostrarmaterias()
    {
        Console.WriteLine($"Materias del Curso: {NombreCurso}");
        Console.WriteLine("============================================================");

        for (int i = 0; i < materias.Count; i++)
        {
            Console.WriteLine($"#{i + 1}: {materias[i]}");
        }

        Console.WriteLine("============================================================");
    }
}

class Programa
{
    static void Main()
    {
        // Crea un Curso con Especialidad y materias
        Curso curso = new Curso("Segundo de Bachillerato U. E. Juan XXIII");

        // Agregar materias al curso
        curso.AgregarAsignatura("Matemáticas");
        curso.AgregarAsignatura("Física");
        curso.AgregarAsignatura("Química");
        curso.AgregarAsignatura("Historia");
        curso.AgregarAsignatura("Lengua");

        // Mostrar las materias registradas
        curso.Mostrarmaterias();
    }
}